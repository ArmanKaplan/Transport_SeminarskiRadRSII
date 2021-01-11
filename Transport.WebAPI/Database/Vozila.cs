using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class Vozila
    {
        public Vozila()
        {
            Vozaci = new HashSet<Vozaci>();
        }

        public int VoziloId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string RegistracijskeOznake { get; set; }
        public int Kilovati { get; set; }
        public string Boja { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int TipVozilaId { get; set; }

        public virtual TipoviVozila TipVozila { get; set; }
        public virtual ICollection<Vozaci> Vozaci { get; set; }
    }
}
