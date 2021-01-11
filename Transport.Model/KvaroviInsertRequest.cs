using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class KvaroviInsertRequest
    {
        public string Lokacija { get; set; }
        public string Opis { get; set; }
        public bool Prioritetno { get; set; }
        public int VoznjaId { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
    }
}
