using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class VoznjeSearchRequest
    {
        public int? Zavrsen { get; set; }
        public int? VoznjaID { get; set; }
        public int? Prihvacen { get; set; }
    }
}
