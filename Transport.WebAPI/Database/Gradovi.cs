using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            Klijenti = new HashSet<Klijenti>();
            Vozaci = new HashSet<Vozaci>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Klijenti> Klijenti { get; set; }
        public virtual ICollection<Vozaci> Vozaci { get; set; }
    }
}
