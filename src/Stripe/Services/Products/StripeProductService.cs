using System.Collections.Generic;

namespace Stripe
{
    public class StripeProductService : StripeService
    {
        public StripeProductService(string apiKey = null) : base(apiKey) { }

        public virtual StripeProduct Create(StripeProductCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(createOptions, Urls.Plans, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeProduct>.MapFromJson(response);
        }

        public virtual StripeProduct Get(string planId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Plans, planId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeProduct>.MapFromJson(response);
        }

        public virtual void Delete(string planId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Products, planId);

            Requestor.Delete(url, requestOptions);
        }

        public virtual StripeProduct Update(string planId, StripeProductUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Plans, planId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeProduct>.MapFromJson(response);
        }

        public virtual IEnumerable<StripeProduct> List(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = Urls.Plans;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeProduct>.MapCollectionFromJson(response);
        }
    }
}