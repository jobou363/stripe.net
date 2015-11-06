using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeProduct : StripeObject
    {
        [JsonProperty("active")] 
        public bool Active { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("updated")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Updated { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("shippable")]
        public bool Shippable { get; set; }

        [JsonProperty("package_dimensions")]
        public Dictionary<string, string> PackageDimensions { get; set; }

        [JsonProperty("images")]
        public string[] Images { get; set; }

        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }

        [JsonProperty("skus")]
        public StripeList<StripeSkus> Skus { get; set; }
    }

    public class StripeSkus
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }
}