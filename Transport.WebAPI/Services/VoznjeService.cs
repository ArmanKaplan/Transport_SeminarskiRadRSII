using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Transport.Model;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public class VoznjeService : BaseCRUDService<Model.Voznje, VoznjeSearchRequest, VoznjeInsertRequest, VoznjeUpdateRequest,Database.Voznje>
    {
        private readonly IVozaciService _vozaciService;
        private readonly IKlijentiService _klijentiService;

        public VoznjeService(TransportContext context, IMapper mapper, IVozaciService vozaciService, IKlijentiService klijentiService) : base(context, mapper)
        {
            _vozaciService = vozaciService;
            _klijentiService = klijentiService;
        }
        public override List<Model.Voznje> Get(VoznjeSearchRequest search = null)
        {
            var query = _context.Set<Database.Voznje>().AsQueryable();

            query = query.Include(x => x.Zahtjev).Include(x=>x.Vozac);

            if (search?.Zavrsen.HasValue == true && search.Zavrsen == 0)
            {
                query = query.Where(x => x.Zavrsen == false);

            }
            else if (search?.Zavrsen.HasValue == true && search.Zavrsen == 1)
            {
                query = query.Where(x => x.Zavrsen == true);
            }

            if(_vozaciService.GetLogovaniVozac() != null)
            {
                query = query.Where(x => x.VozacId == _vozaciService.GetLogovaniVozac().VozacID);
            }
            if (_klijentiService.GetLogovaniKlijent() != null)
            {
                query = query.Where(x => x.Zahtjev.KlijentId == _klijentiService.GetLogovaniKlijent().KlijentId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Voznje>>(list);
        }
    }

}
