using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public class VozilaService : BaseCRUDService<Model.Vozila, VozilaSearchRequest, VozilaInsertRequest, VozilaUpdateRequest, Database.Vozila>
    {
        public VozilaService(TransportContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Vozila> Get(VozilaSearchRequest search)
        {
            var query = _context.Set<Database.Vozila>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.RegistracijskeOznake))
            {
                query = query.Where(x => x.RegistracijskeOznake.StartsWith(search.RegistracijskeOznake));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Vozila>>(list);
        }
    }
}
