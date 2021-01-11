using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Transport.Model
{
   public class ZahtjevInsertRequest
    {
        //public int ZahtjevId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string VrstaRobe { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int TipVozilaId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LokacijaUtovara { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LokacijaIstovara { get; set; }
        [Required(AllowEmptyStrings = false)]
        public DateTime DatumTransporta { get; set; }
        
        public string Napomena { get; set; }
        [Required(AllowEmptyStrings = false)]
        public bool Obradjen { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int KlijentId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int TipRobeId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public bool Odbijen { get; set; }
        public bool Uplaceno { get; set; }
       
        public string Transakcija { get; set; }
    }
}
