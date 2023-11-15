using Newtonsoft.Json;

namespace Gw2SalvageCalculator.Api.ApiResponses
{
    public class DetailsResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("weight_class")]
        public string WeightClass { get; set; }

        [JsonProperty("defense")]
        public long Defense { get; set; }

        [JsonProperty("infusion_slots")]
        public object[] InfusionSlots { get; set; }

        [JsonProperty("attribute_adjustment")]
        public double AttributeAdjustment { get; set; }
    }
}
