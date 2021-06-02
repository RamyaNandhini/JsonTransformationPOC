using Newtonsoft.Json;
using System;

namespace JsonTransformationPOC.Model
{
    public class ItemCategory
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
        public string Code { get; set; }
        public string DisplayName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModifiedDateTime { get; set; }

        public int ItemCategoryId { get; set; }
    }
}
