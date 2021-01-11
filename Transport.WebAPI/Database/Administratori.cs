using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class Administratori
    {
        public Administratori()
        {
            Lociranja = new HashSet<Lociranja>();
        }

        public int AdministratorId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public virtual ICollection<Lociranja> Lociranja { get; set; }
    }
}
