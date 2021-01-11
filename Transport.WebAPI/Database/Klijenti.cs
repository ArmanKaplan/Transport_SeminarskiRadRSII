using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class Klijenti
    {
        public Klijenti()
        {
            Lociranja = new HashSet<Lociranja>();
            Zahtjevi = new HashSet<Zahtjevi>();
        }

        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Firma { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public int GradId { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }

        public virtual Gradovi Grad { get; set; }
        public virtual ICollection<Lociranja> Lociranja { get; set; }
        public virtual ICollection<Zahtjevi> Zahtjevi { get; set; }
    }
}
