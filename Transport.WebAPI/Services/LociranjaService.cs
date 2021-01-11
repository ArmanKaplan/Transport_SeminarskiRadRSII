using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public class LociranjaService : BaseCRUDService<Model.Lociranja, LociranjaSerachRequest, LociranjaInsertRequest, LociranjaUpdateRequest, Database.Lociranja>
    {
        public LociranjaService(TransportContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override  List<Model.Lociranja> Get(LociranjaSerachRequest search =null)
        {
            var query = _context.Set<Database.Lociranja>().AsQueryable();

            query = query.Include(x => x.Klijent).Include(x => x.Administrator);

            var list = query.ToList();

            return _mapper.Map<List<Model.Lociranja>>(list);
        }
    }
}
