using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class Obavijesti
    {
        public int ObavijestId { get; set; }
        public string Tekst { get; set; }
        public DateTime Datum { get; set; }
        public int VoznjaId { get; set; }

        public virtual Voznje Voznja { get; set; }
    }
}
