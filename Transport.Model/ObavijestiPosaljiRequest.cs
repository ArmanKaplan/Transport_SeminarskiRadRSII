using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class ObavijestiPosaljiRequest
    {
      
        public string Tekst { get; set; }
        public DateTime Datum { get; set; }
        public int VoznjaId { get; set; }
    }
}
