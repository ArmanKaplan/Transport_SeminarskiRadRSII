using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Transport.Model;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public class KvaroviService : BaseCRUDService<Model.Kvarovi, KvaroviSearchRequest, KvaroviInsertRequest, object, Database.Kvarovi>
    {
        public KvaroviService(TransportContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Kvarovi> Get(KvaroviSearchRequest search = null)
        {
            var query = _context.Kvarovi.AsQueryable();

            if (search.VoznjaID != 0)
            {
                query = query.Where(x => x.VoznjaId == search.VoznjaID);
            }


            var list = query.ToList();

            return _mapper.Map<List<Model.Kvarovi>>(list);
        }
     

    }
}
