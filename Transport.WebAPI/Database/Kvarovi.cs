using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class Kvarovi
    {
        public int KvarId { get; set; }
        public string Lokacija { get; set; }
        public string Opis { get; set; }
        public bool Prioritetno { get; set; }
        public int VoznjaId { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public virtual Voznje Voznja { get; set; }
    }
}
