using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class Voznje
    {
        public Voznje()
        {
            Kvarovi = new HashSet<Kvarovi>();
            Lociranja = new HashSet<Lociranja>();
            Obavijesti = new HashSet<Obavijesti>();
        }

        public int VoznjaId { get; set; }
        public bool Prihvacen { get; set; }
        public int Kilometraza { get; set; }
        public decimal Cijena { get; set; }
        public int VozacId { get; set; }
        public string Napomena { get; set; }
        public bool Zapoceto { get; set; }
        public bool Zavrsen { get; set; }
        public int? Ocjena { get; set; }
        public bool Ocijenjen { get; set; }
        public int ZahtjevId { get; set; }
        public bool Odgovoren { get; set; }

        public virtual Vozaci Vozac { get; set; }
        public virtual Zahtjevi Zahtjev { get; set; }
        public virtual ICollection<Kvarovi> Kvarovi { get; set; }
        public virtual ICollection<Lociranja> Lociranja { get; set; }
        public virtual ICollection<Obavijesti> Obavijesti { get; set; }
    }
}
