using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class TipoviRoba
    {
        public TipoviRoba()
        {
            Zahtjevi = new HashSet<Zahtjevi>();
        }

        public int TipRobeId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Zahtjevi> Zahtjevi { get; set; }
    }
}
