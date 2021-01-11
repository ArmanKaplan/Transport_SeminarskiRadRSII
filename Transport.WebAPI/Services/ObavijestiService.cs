using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Transport.Model;
using Transport.WebAPI.Database;

namespace Transport.WebAPI.Services
{
    public class ObavijestiService : BaseCRUDService<Model.Obavijesti, object, ObavijestiPosaljiRequest, object, Database.Vozila>
    {
        public ObavijestiService(TransportContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
