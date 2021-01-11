using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class Vozaci
    {
        public Vozaci()
        {
            Voznje = new HashSet<Voznje>();
        }

        public int VozacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Jmbg { get; set; }
        public string MjestoRodjenja { get; set; }
        public string Adresa { get; set; }
        public int? GodineIskustva { get; set; }
        public string KorisnickoIme { get; set; }
        public int GradId { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        public int VoziloId { get; set; }

        public virtual Gradovi Grad { get; set; }
        public virtual Vozila Vozilo { get; set; }
        public virtual ICollection<Voznje> Voznje { get; set; }
    }
}
