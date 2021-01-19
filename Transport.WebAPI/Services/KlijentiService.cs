using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Stripe;
using Transport.Model;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public class KlijentiService : IKlijentiService
    {
        public TransportContext _context { get; }
        public IMapper _mapper { get; }
        private Model.Klijenti _logovaniKlijent;
        public KlijentiService(TransportContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Model.Klijenti GetLogovaniKlijent()
        {
            return _logovaniKlijent;
        }

        public void SetLogovaniKlijent(Model.Klijenti user)
        {
            _logovaniKlijent = user;
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.Klijenti Authenticiraj(LoginSearchRequest request)
        {

            var entity = _context.Klijenti.FirstOrDefault(x => x.KorisnickoIme == request.KorisnickoIme);

            if (entity == null)
            {
                return null;
            }

            var hash = GenerateHash(entity.LozinkaSalt, request.Lozinka);

            if (hash != entity.LozinkaHash)
            {
                return null;
            }

            return _mapper.Map<Model.Klijenti>(entity);
        }

        public Model.Klijenti Insert(KlijentiInsertRequest request)
        {
            var entity = _mapper.Map<Database.Klijenti>(request);
            _context.Add(entity);

            if (request.Password != request.PasswordPotvrda)
            {

                throw new UserException("Password i potvrda se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.SaveChanges();


            return _mapper.Map<Model.Klijenti>(entity);
        }

        public Model.Klijenti Update(int id, KlijentiUpdateRequest request)
        {
            var entity = _context.Klijenti.Find(id);

            _mapper.Map(request, entity);

            if (!string.IsNullOrEmpty(request.Password))
            {
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Klijenti>(entity);

        }

        public List<Model.Klijenti> Get(KlijentiSearchRequest search)
        {
            var query = _context.Set<Database.Klijenti>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(search.Ime)||x.Prezime.StartsWith(search.Prezime));
            }
          // if (!string.IsNullOrWhiteSpace(search?.Prezime))
          //  {
          //      query = query.Where(x => x.Prezime.StartsWith(search.Prezime));
          //  }


            var list = query.ToList();
            return _mapper.Map<List<Model.Klijenti>>(list);
        }

        public Model.Klijenti GetById(int id)
        {
            var entity = _context.Klijenti.Find(id);

            return _mapper.Map<Model.Klijenti>(entity);
        }

        public Model.MyPaymentIntent CreatePaymentIntent(CreatePaymentIntentRequest request)
        {
            StripeConfiguration.ApiKey = "sk_test_51HMbXNDgsIuvPoP0Ronbq2wigL6Bsz9FjOilv4AbLG9GzVNaYX6Gw8iUzrVYIdaxJH0MXuaLILGJ8sEcgreQavhO00DfdacVp6";

            var options = new PaymentIntentCreateOptions
            {
                Amount = request.Amount,
                Currency = "EUR",
                PaymentMethodTypes = new List<string> { "card", }
            };
            var service = new PaymentIntentService();
            Stripe.PaymentIntent intent = service.Create(options);
            if (intent == null)
                return null;

            return new Model.MyPaymentIntent
            {
                Id = intent.Id,
                Amount = intent.Amount,
                Status = intent.Status,
                Currency = intent.Currency,
                PaymentMethodId = intent.PaymentMethodId,
                Created = intent.Created
            };
        }
    }
}
