using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Transport.Model
{
   public partial class Vozaci
    {
        public int VozacID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Jmbg { get; set; }
        public string MjestoRodjenja { get; set; }
        public string Adresa { get; set; }
        public int? GodineIskustva { get; set; }
        public string KorisnickoIme { get; set; }
        public int VoziloID { get; set; }
        public int GradID { get; set; }
        public string ImeIPrezime
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }
       
        public override string ToString()
        {
            return Ime;


        }
    }

}
