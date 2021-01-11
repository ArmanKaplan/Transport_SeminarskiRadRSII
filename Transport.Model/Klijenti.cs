using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class Klijenti
    {
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Firma { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public int GradId { get; set; }
        public Gradovi Grad { get; set; }
    }
}
