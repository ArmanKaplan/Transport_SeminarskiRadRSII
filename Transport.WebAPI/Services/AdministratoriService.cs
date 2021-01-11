using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public class AdministratoriService:IAdministratorService

    {
        private readonly TransportContext _context;
        private readonly IMapper _mapper;
        public AdministratoriService(TransportContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public Model.Administratori Authenticiraj(LoginSearchRequest request)
        {
            var user = _context.Administratori.FirstOrDefault(x => x.KorisnickoIme == request.KorisnickoIme);
            if (user == null)
            {
                return null;
            }


            if (request.Lozinka != user.Lozinka)
            {
                return null;
            }

            return _mapper.Map<Model.Administratori>(user);
        }

        public List<Model.Administratori> Get(LoginSearchRequest request)
        {
           
                var query = _context.Administratori.AsQueryable();

                if (!string.IsNullOrWhiteSpace(request?.KorisnickoIme))
                {
                    query = query.Where(x => x.KorisnickoIme == request.KorisnickoIme && x.Lozinka == request.Lozinka);
                }

             


                var list = query.ToList();

                return _mapper.Map<List<Model.Administratori>>(list);
            
        }

    
    }
    
    }

