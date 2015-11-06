using System;
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_product_create_options
    {
        public static StripeProductCreateOptions Valid()
        {
            return new StripeProductCreateOptions()
            {
                Id = "test-product-" + Guid.NewGuid(),
                Active = true,
                Caption = "Test Product Caption",
                Name = "Test Product Name",
                Description = "Test Product Description",
                Shippable = false,
                Attributes = new string[] { "Attribute 1", "Attribute 2" },
                PackageDimensions = new Dictionary<string, decimal>
                {
                    { "height", 10m },
                    { "length", 10m },
                    { "weight", 10m },
                    { "width", 10m }
                },
                Url = "https://www.url.url",
                Images = new string[] { "https://www.url.url" },
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }                
            };
        }
    }
}
