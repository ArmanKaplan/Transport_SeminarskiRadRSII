using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Services;

namespace Transport.WebAPI.Controllers
{
    public class ZahtjeviController : BaseCRUDController<Model.Zahtjevi, ZahtjeviSearchRequest, ZahtjevInsertRequest, ZahtjeviOdgovorRequest>
    {
        private readonly IZahtjeviService _service;

        public ZahtjeviController(IZahtjeviService service) : base(service)
        {
            _service = service;
        }

        [HttpPost("UplataIzvrsena")]
        [AllowAnonymous]
        public bool UplataIzvrsena([FromBody] ZahtjeviUplataIzvrsenaRequest request)
        {
            return _service.UplataIzvrsena(request);
        }
    }

}
