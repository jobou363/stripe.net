using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_product_update_options
    {
        public static StripeProductUpdateOptions Valid()
        {
            return new StripeProductUpdateOptions()
            {
                Name = "Name Modified",
                Active = true,
                Caption = "Caption Modified",
                Description = "Description Modified",
                Images = new string[] { "https://www.google.com" },
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" },
                    { "C", "Value-C" }
                }             
            };
        }
    }
}
