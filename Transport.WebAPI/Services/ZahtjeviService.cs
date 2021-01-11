using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Stripe;
using Transport.Model;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public class ZahtjeviService : BaseCRUDService<Model.Zahtjevi, ZahtjeviSearchRequest, ZahtjevInsertRequest, ZahtjeviOdgovorRequest,Database.Zahtjevi>, IZahtjeviService
    {
        private readonly IKlijentiService _klijentiService;
        public ZahtjeviService(TransportContext context, IMapper mapper,IKlijentiService klijentiService) : base(context, mapper)
        {
            _klijentiService = klijentiService;
        }

        public override List<Model.Zahtjevi> Get(ZahtjeviSearchRequest search=null)
        {
            var query = _context.Set<Database.Zahtjevi>().AsQueryable();

            if (search?.Obradjen.HasValue == true && search.Obradjen == 1)
            {
                query = query.Where(x => x.Obradjen == true);
           
            }
            else if(search?.Obradjen.HasValue == true && search.Obradjen == 0 )
            {
                query = query.Where(x => x.Obradjen == false);
            }
            if (_klijentiService.GetLogovaniKlijent() != null)
            {
                query = query.Where(x => x.KlijentId == _klijentiService.GetLogovaniKlijent().KlijentId);
            }
            var list = query.ToList();

            return _mapper.Map<List<Model.Zahtjevi>>(list);
        }

        public bool UplataIzvrsena(ZahtjeviUplataIzvrsenaRequest request)
        {
            StripeConfiguration.ApiKey = "sk_test_51HMbXNDgsIuvPoP0Ronbq2wigL6Bsz9FjOilv4AbLG9GzVNaYX6Gw8iUzrVYIdaxJH0MXuaLILGJ8sEcgreQavhO00DfdacVp6";

            var Zahtjev = _context.Zahtjevi.Where(x => x.ZahtjevId == request.ZahtjevId).FirstOrDefault();
            if (Zahtjev == null)
                return false;

            var Voznja = _context.Voznje.Where(x => x.ZahtjevId == request.ZahtjevId).FirstOrDefault();
            if(Voznja == null)
                return false;

            var options = new PaymentIntentCreateOptions
            {
                Amount = Convert.ToInt32(Voznja.Cijena * 100),
                Currency = "EUR",
                PaymentMethodTypes = new List<string> { "card", },
                PaymentMethod = request.PaymentMethodId,
                ErrorOnRequiresAction = true,
                Confirm = true,
                Metadata = new Dictionary<string, string>()
            };
            options.Metadata["ZahtjevId"] = request.ZahtjevId.ToString();

            var service = new PaymentIntentService();
            Stripe.PaymentIntent intent = service.Create(options);
            if (intent == null)
                return false;

            var success = false;

            foreach (var charge in intent.Charges)
            {
                if (charge.Paid)
                {
                    success = true;

                    if (intent.Metadata.ContainsKey("ZahtjevId"))
                    {
                        int ZahtjevId = int.Parse(intent.Metadata["ZahtjevId"]);
                        var Zahtjev1 = _context.Zahtjevi.Where(x => x.ZahtjevId == ZahtjevId).FirstOrDefault();
                        if(Zahtjev1 != null) {
                            Zahtjev1.Uplaceno = true;
                            Zahtjev1.Transakcija = charge.PaymentIntentId;
                            _context.SaveChanges();
                        }
                    }
                }
            }

            return success;
        }
    }
}
