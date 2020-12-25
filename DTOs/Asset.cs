using Newtonsoft.Json;
using System;

namespace BlockchainFue.DTOs
{
    public class Asset
    {
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("data")]
        public AssetData Data { get; set; }
        
        [JsonProperty("metadata")]
        public AssetMetadata Metadata { get; set; }
    }
}