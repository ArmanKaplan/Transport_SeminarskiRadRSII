using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Transport.Model
{
   public class VozaciUpdateRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Jmbg { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string MjestoRodjenja { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Adresa { get; set; }

        public int? GodineIskustva { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int VoziloID { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int GradID { get; set; }


    }
}
