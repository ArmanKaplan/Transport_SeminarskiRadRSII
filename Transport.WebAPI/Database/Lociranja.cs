using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class Lociranja
    {
        public int LociranjeId { get; set; }
        public int VoznjaId { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public bool Prihvaceno { get; set; }
        public bool Odogovoreno { get; set; }
        public int? KlijentId { get; set; }
        public int? AdministratorId { get; set; }

        public virtual Administratori Administrator { get; set; }
        public virtual Klijenti Klijent { get; set; }
        public virtual Voznje Voznja { get; set; }
    }
}
