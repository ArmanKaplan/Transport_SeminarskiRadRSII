using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class VoznjeInsertRequest
    {
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
    }
}
