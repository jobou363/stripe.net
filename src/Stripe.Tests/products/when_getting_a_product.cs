using Machine.Specifications;

namespace Stripe.Tests
{

    public class when_getting_a_product
    {
        protected static StripeProductCreateOptions StripeProductCreateOptions;      
        protected static StripeProduct StripeProduct;

        private static StripeProductService _stripeProductService;
        private static string _createdStripeProductId;

        Establish context = () =>
        {
            _stripeProductService = new StripeProductService();
            StripeProductCreateOptions = test_data.stripe_product_create_options.Valid();


            var stripeProduct = _stripeProductService.Create(StripeProductCreateOptions);
            _createdStripeProductId = stripeProduct.Id;
        };

        Because of = () => StripeProduct = _stripeProductService.Get(_createdStripeProductId);

        Behaves_like<product_behaviors> behaviors;

        It should_have_active_product = () => StripeProduct.Active.ShouldNotBeNull();

       
    }
}