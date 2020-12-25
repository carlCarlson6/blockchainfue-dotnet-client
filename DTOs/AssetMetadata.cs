using Newtonsoft.Json;
using System;

namespace BlockchainFue.DTOs
{
    public class AssetMetadata
    {
        [JsonProperty("action")]
        public String Action { get; set; }

        [JsonProperty("updated_at")]
        public String UpdatedAt { get; set; }

        [JsonProperty("from")]
        public String From { get; set; }

        [JsonProperty("to")]
        public String To { get; set; }

        [JsonProperty("assetObjectMetadata")]
        public dynamic AssetObjectMetadata { get; set; }
    }
}