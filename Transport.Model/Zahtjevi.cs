using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class Zahtjevi
    {

        public int ZahtjevId { get; set; }
        public string VrstaRobe { get; set; }
        public int TipVozilaId { get; set; }
        public string LokacijaUtovara { get; set; }
        public string LokacijaIstovara { get; set; }
        public DateTime DatumTransporta { get; set; }
        public string Napomena { get; set; }
        public bool Obradjen { get; set; }
        public int KlijentId { get; set; }
        public int TipRobeId { get; set; }
        public bool Uplaceno { get; set; }
        public bool Odbijen { get; set; }
        public string Transakcija { get; set; }
        public bool NijePlaceno => !Uplaceno;
        public bool NijeOdbijen => !Odbijen;
        public override string ToString()
        {
            return LokacijaUtovara;
            
       
        }
        public string Datum
        {
            get
            {
                

                return DatumTransporta.ToShortDateString();
            }
        }
    }
}
