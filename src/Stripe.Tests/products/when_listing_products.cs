using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_products
    {
        private static List<StripeProduct> _stripeProductList;
        private static StripeProductService _stripeProductService;

        Establish context = () =>
        {
            _stripeProductService = new StripeProductService();

            _stripeProductService.Create(test_data.stripe_product_create_options.Valid());
            _stripeProductService.Create(test_data.stripe_product_create_options.Valid());
            _stripeProductService.Create(test_data.stripe_product_create_options.Valid());
            _stripeProductService.Create(test_data.stripe_product_create_options.Valid());
        };

        Because of = () =>
            _stripeProductList = _stripeProductService.List().ToList();

        It should_have_atleast_4_entries = () =>
            _stripeProductList.Count.ShouldBeGreaterThanOrEqualTo(4);
    }
}