using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class Vozila
    {
        public int VoziloId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string RegistracijskeOznake { get; set; }
        public int Kilovati { get; set; }
        public string Boja { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int TipVozilaId { get; set; }
        public string VoziloMarka
        {
            get
            {
               

                return Marka+" "+Model+" "+RegistracijskeOznake;
            }
        }

    }
}
