using Newtonsoft.Json;

namespace Gw2SalvageCalculator.Api.ApiResponses
{
    public class ItemResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("vendor_value")]
        public long VendorValue { get; set; }

        [JsonProperty("default_skin")]
        public long DefaultSkin { get; set; }

        [JsonProperty("game_types")]
        public string[] GameTypes { get; set; }

        [JsonProperty("flags")]
        public object[] Flags { get; set; }

        [JsonProperty("restrictions")]
        public object[] Restrictions { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("chat_link")]
        public string ChatLink { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("details")]
        public DetailsResponse Details { get; set; }
    }
}
