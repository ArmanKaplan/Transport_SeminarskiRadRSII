using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public class BaseService<TModel, TSearch,TDatabase> : IService<TModel, TSearch>where TDatabase:class
    {
        protected readonly TransportContext _context;
        protected readonly IMapper _mapper;
        public  BaseService(TransportContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public virtual List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(entity);
        }
    }
}
