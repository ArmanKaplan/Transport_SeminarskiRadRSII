using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class Voznje
    {
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
        public virtual Zahtjevi Zahtjev { get; set; }
        public bool Odgovoren { get; set; }
        public bool NijeZavrsen => !Zavrsen;
        public bool NijeZapoceto => !Zapoceto;
        public string DatumTransporta {
            get
            {
                if (Zahtjev == null)
                    return "";

                return Zahtjev.DatumTransporta.ToShortDateString();
            }
        }

        public Vozaci Vozac { get; set; }
      
    }
}
