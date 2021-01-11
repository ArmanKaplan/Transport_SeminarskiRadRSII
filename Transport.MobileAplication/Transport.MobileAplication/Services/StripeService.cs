using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Transport.Model;

namespace Transport.MobileApplication.Services
{
    public class StripeService
    {
        public APIService _klijentiService = new APIService("Klijenti");

        public async Task<Model.MyPaymentIntent> CreatePaymentIntent(int Amount)
        {
            return await _klijentiService.Insert<Model.MyPaymentIntent>(new CreatePaymentIntentRequest
            {
                Amount   = Amount
            });
        }

        public string CreateToken(string cardNumber, string cardExpMonth, string cardExpYear, string cardCVC)
        {
            /*StripeConfiguration.SetApiKey("pk_test_xxxxxxxxxxxxxxxxx");
            
            var tokenOptions = new StripeTokenCreateOptions()
            {
                Card = new StripeCreditCardOptions()
                {
                    Number = cardNumber,
                    ExpirationYear = cardExpYear,
                    ExpirationMonth = cardExpMonth,
                    Cvc = cardCVC
                }
            };

            var tokenService = new StripeTokenService();
            StripeToken stripeToken = tokenService.Create(tokenOptions);

            return stripeToken.Id; // This is the token*/
            return "";
        }
    }
}
