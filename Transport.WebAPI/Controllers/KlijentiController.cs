using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Model;
using Transport.WebAPI.Services;

namespace Transport.WebAPI.Controllers
{
    public class KlijentiController : BaseCRUDController<Model.Klijenti, KlijentiSearchRequest, KlijentiInsertRequest, KlijentiUpdateRequest>
    {
        private readonly IKlijentiService _service;

        public KlijentiController(IKlijentiService service) : base(service)
        {
            _service = service;
        }


        [HttpGet("login")]
        [Authorize(Roles = "Klijent")]
        public Model.Klijenti Authenticiraj([FromQuery] LoginSearchRequest request)
        {
            return _service.Authenticiraj(request);
        }

        [HttpPost("createPaymentIntent")]
        [Authorize(Roles = "Klijent")]
        public Model.MyPaymentIntent CreatePaymentIntent([FromBody] CreatePaymentIntentRequest request)
        {
            return _service.CreatePaymentIntent(request);
        }

        [AllowAnonymous]
        [HttpPost("Registracija")]
        public Model.Klijenti Registracija(KlijentiInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
