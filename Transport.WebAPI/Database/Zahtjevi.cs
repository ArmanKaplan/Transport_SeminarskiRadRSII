using System;
using System.Collections.Generic;

namespace Transport.WebAPI.Database
{
    public partial class Zahtjevi
    {
        public Zahtjevi()
        {
            Voznje = new HashSet<Voznje>();
        }

        public int ZahtjevId { get; set; }
        public string VrstaRobe { get; set; }
        public int TipVozilaId { get; set; }
        public string LokacijaUtovara { get; set; }
        public string LokacijaIstovara { get; set; }
        public DateTime DatumTransporta { get; set; }
        public string Napomena { get; set; }
        public bool Obradjen { get; set; }
        public int KlijentId { get; set; }
        public int TipRobeId { get; set; }
        public bool Uplaceno { get; set; }
        public bool Odbijen { get; set; }
        public string Transakcija { get; set; }

        public virtual Klijenti Klijent { get; set; }
        public virtual TipoviRoba TipRobe { get; set; }
        public virtual TipoviVozila TipVozila { get; set; }
        public virtual ICollection<Voznje> Voznje { get; set; }
    }
}
