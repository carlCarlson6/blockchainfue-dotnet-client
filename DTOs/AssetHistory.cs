using Newtonsoft.Json;
using System;

namespace BlockchainFue.DTOs
{
    public class AssetHistory
    {
        [JsonProperty("id")]
        public String TransactionId { get; set; }

        [JsonProperty("metadata")]
        public AssetMetadata Metadata { get; set; }
    }
}
