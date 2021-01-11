using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Transport.Model
{
   public class VozilaInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Marka { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Model { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string RegistracijskeOznake { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int Kilovati { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Boja { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int GodinaProizvodnje { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int TipVozilaId { get; set; }
    }
}
