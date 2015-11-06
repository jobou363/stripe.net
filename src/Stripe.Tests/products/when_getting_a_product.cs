using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_product
    {
        protected static StripeProduct StripeProduct;

        private static StripeProductService _stripeProductService;
        private static string _createdStripeProductId;

        Establish context = () =>
        {
            _stripeProductService = new StripeProductService();
           
            var stripeProduct = _stripeProductService.Create(StripeProductCreateOptions);
            _createdStripeProductId = stripeProduct.Id;
        };

        Because of = () => StripeProduct = _stripeProductService.Get(_createdStripeProductId);

        Behaves_like<plan_behaviors> behaviors;
    }
}