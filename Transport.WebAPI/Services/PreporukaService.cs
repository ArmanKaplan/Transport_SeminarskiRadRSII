using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public class PreporukaService : IPreporukaService
    {
        private readonly TransportContext _context;
        private readonly IMapper _mapper;
        private readonly IKlijentiService _klijentiService;

        private readonly int MaxBrojPreporuka = 5;

        public PreporukaService(TransportContext context, IMapper mapper, IKlijentiService klijentiService)
        {
            _context = context;
            _mapper = mapper;
            this._klijentiService = klijentiService;
        }

        public List<Model.Zahtjevi> PreporuciLokacijuIstovara()
        {
            var KlijentId = _klijentiService.GetLogovaniKlijent().KlijentId;

            var listLokacijeIstovara = _context.Zahtjevi
                .Where(x => x.KlijentId == KlijentId)
                .GroupBy(x => x.LokacijaIstovara)
                .OrderByDescending(x => x.Count())
                .Select(x=>x.Key)
                .Take(MaxBrojPreporuka)
                .ToList();

            List<Database.Zahtjevi> listaZahtjevaZaLokacije = new List<Database.Zahtjevi>();
            foreach (var lokacijaIstovara in listLokacijeIstovara)
            {
                var zahtjev = _context.Zahtjevi
                    .Where(x => x.KlijentId == KlijentId)
                    .Where(x => x.LokacijaIstovara == lokacijaIstovara)
                    .OrderByDescending(x => x.DatumTransporta)
                    .Take(1)
                    .FirstOrDefault();

                if(zahtjev != null)
                {
                    listaZahtjevaZaLokacije.Add(zahtjev);
                }
            }

            return _mapper.Map<List<Model.Zahtjevi>>(listaZahtjevaZaLokacije);
        }
    }

}

