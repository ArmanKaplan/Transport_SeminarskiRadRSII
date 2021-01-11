using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Model
{
    public class LociranjaInsertRequest
    {
        
        public int VoznjaId { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public bool Prihvaceno { get; set; }
        public bool Odogovoreno { get; set; }
        public int? KlijentId { get; set; }
        public int? AdministratorId { get; set; }
    }
}
