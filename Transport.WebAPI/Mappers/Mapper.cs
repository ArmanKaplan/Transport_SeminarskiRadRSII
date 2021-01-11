using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;

namespace Transport.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Vozaci, Model.Vozaci>();
            CreateMap<Database.Zahtjevi, Model.Zahtjevi>();
            CreateMap<Database.Voznje, Model.Voznje>();
            CreateMap<Database.Kvarovi, Model.Kvarovi>();
            CreateMap<Database.Vozila, Model.Vozila>();
            CreateMap<Database.Klijenti, Model.Klijenti>();
            CreateMap<Database.Lociranja, Model.Lociranja>();
            CreateMap<Database.TipoviRoba, Model.TipoviRoba>();
            CreateMap<Database.Obavijesti, Model.Obavijesti>();
            CreateMap<Database.Gradovi, Model.Gradovi>();
            CreateMap<Database.TipoviVozila, Model.TipVozila>();
            CreateMap<Database.Administratori,Model.Administratori>();
            CreateMap<Database.Administratori, Model.Administratori>().ReverseMap();
            CreateMap<Model.VozaciInsertRequest, Database.Vozaci>();
            CreateMap<Model.VozilaInsertRequest, Database.Vozila>();
            CreateMap<Model.ZahtjeviOdgovorRequest, Database.Zahtjevi>();
            CreateMap<Model.ZahtjevInsertRequest, Database.Zahtjevi>();
            CreateMap<Model.VoznjeInsertRequest, Database.Voznje>();
            CreateMap<Model.VoznjeUpdateRequest, Database.Voznje>();
            CreateMap<Model.ObavijestiPosaljiRequest, Database.Obavijesti>();
            CreateMap<Model.VozilaUpdateRequest, Database.Vozila>();
            CreateMap<Model.VozaciUpdateRequest, Database.Vozaci>();
            CreateMap<Model.LociranjaUpdateRequest, Database.Lociranja>();
            CreateMap<Model.LociranjaInsertRequest, Database.Lociranja>();
            CreateMap<Model.KlijentiUpdateRequest, Database.Klijenti>();
            CreateMap<Model.KvaroviInsertRequest, Database.Kvarovi>();
            CreateMap<Model.KlijentiUpdateRequest, Database.Klijenti>().ReverseMap();
            CreateMap<Model.KlijentiInsertRequest, Database.Klijenti>();
        }
    }
}
