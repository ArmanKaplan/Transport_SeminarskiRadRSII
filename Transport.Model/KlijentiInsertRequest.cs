using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Transport.Model
{
    public class KlijentiInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Firma { get; set; }
        [Required(AllowEmptyStrings = false)]
    
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string Telefon { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int GradId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(6)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(6)]
        public string PasswordPotvrda { get; set; }
    }
}
