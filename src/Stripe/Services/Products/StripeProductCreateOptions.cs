using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeProductCreateOptions
    {
        [JsonProperty("id")]
        public string Id { get; set; }
  
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("images")]
        public string[] Images { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("package_dimensions")]
        public Dictionary<string, string> PackageDimensions { get; set; }

        [JsonProperty("shippable")]
        public bool Shippable { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
