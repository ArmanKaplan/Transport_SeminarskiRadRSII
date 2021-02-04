using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class VozaciService : IVozaciService
    {
        private readonly TransportContext _context;
        private readonly IMapper _mapper;
        private Model.Vozaci _logovaniVozac;

        public VozaciService(TransportContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Transport.Model.Vozaci Authenticiraj(LoginSearchRequest request)
        {
            var user = _context.Vozaci.FirstOrDefault(x => x.KorisnickoIme == request.KorisnickoIme);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, request.Lozinka);

                if (hashedPass == user.LozinkaHash)
                {
                    return _mapper.Map<Transport.Model.Vozaci>(user);
                }
            }

            return null;
        }
        public List<Model.Vozaci> Get(VozaciSearchRequest request)
        {
            var query = _context.Vozaci.AsQueryable();

            query = query.Include(x => x.Vozilo);
            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime) || x.Prezime.StartsWith(request.Prezime));
            }
            //if (!string.IsNullOrWhiteSpace(request?.Ime))
            //{
            //    query = query.Where(x => x.Ime.StartsWith(request.Ime) && x.Prezime.StartsWith(request.Prezime));
            //}


            var list = query.ToList();

            return _mapper.Map<List<Model.Vozaci>>(list);
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
        public Model.Vozaci Insert(VozaciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Vozaci>(request);
            _context.Add(entity);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Password i potvrda se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.SaveChanges();


            return _mapper.Map<Model.Vozaci>(entity);
        }

        public Model.Vozaci GetById(int id)
        {
            var entity = _context.Vozaci.Find(id);

            return _mapper.Map<Model.Vozaci>(entity);
        }

        public Model.Vozaci Update(int id, VozaciUpdateRequest request)
        {
            
                //doboavljanje iz baze
                var entity = _context.Vozaci.Find(id);

                _mapper.Map(request, entity);

                _context.SaveChanges();

                return _mapper.Map<Model.Vozaci>(entity);
            
        }

        public Model.Vozaci GetLogovaniVozac()
        {
            return _logovaniVozac;
        }

        public void SetLogovaniVozac(Model.Vozaci user)
        {
            _logovaniVozac = user;
        }

    }
}
