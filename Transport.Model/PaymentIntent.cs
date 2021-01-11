using System;
using System.Collections.Generic;
using System.Text;
using Stripe;

namespace Transport.Model
{
    public class MyPaymentIntent
    {
        public string Id { get; set; }
        public long Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public string PaymentMethodId { get; set; }
        public DateTime Created { get; set; }
    }
}
