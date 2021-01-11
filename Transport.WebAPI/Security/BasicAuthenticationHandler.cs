

using Transport.WebAPI.Database;
using Transport.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Transport.WebAPI.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IAdministratorService _adminService;
        private readonly IKlijentiService _klijentiService;
        private readonly IVozaciService _vozaciService;
     
        
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IAdministratorService adminService,
            IKlijentiService klijentiService,
            IVozaciService vozaciService)
            : base(options, logger, encoder, clock)
        {
            _adminService = adminService;
            _klijentiService = klijentiService;
            _vozaciService = vozaciService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            string role = null;
            string name_identifier = null;

            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];

                Model.Administratori admin = _adminService.Authenticiraj(
                new Model.LoginSearchRequest()
                {
                    KorisnickoIme = username,
                    Lozinka = password
                });
                if (admin != null)
                {
                    role = "Administrator";
                    name_identifier = admin.KorisnickoIme;
                   
                }


                Model.Klijenti klijent = _klijentiService.Authenticiraj(
                new Model.LoginSearchRequest()
                {
                    KorisnickoIme = username,
                    Lozinka = password
                });
                if (klijent != null)
                {
                    role = "Klijent";
                    name_identifier = klijent.KorisnickoIme;
                    _klijentiService.SetLogovaniKlijent(klijent);
                }


                Model.Vozaci vozac = _vozaciService.Authenticiraj(
                new Model.LoginSearchRequest()
                {
                    KorisnickoIme = username,
                    Lozinka = password
                });
                if (vozac != null)
                {
                    role = "Vozac";
                    name_identifier = vozac.KorisnickoIme;
                    _vozaciService.SetLogovaniVozac(vozac);
                }
               
                   
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (name_identifier == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, name_identifier)
            };

            claims.Add(new Claim(ClaimTypes.Role, role));

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
