using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class TipoviVozila
    {
        public TipoviVozila()
        {
            Vozila = new HashSet<Vozila>();
            Zahtjevi = new HashSet<Zahtjevi>();
        }

        public int TipVozilaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Vozila> Vozila { get; set; }
        public virtual ICollection<Zahtjevi> Zahtjevi { get; set; }
    }
}
