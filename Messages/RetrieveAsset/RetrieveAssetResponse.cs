using BlockchainFue.DTOs;
using Newtonsoft.Json;
using System;

namespace BlockchainFue.Messages.RetrieveAsset
{
    internal class RetrieveAssetResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("msg")]
        public String Message { get; set; }

        [JsonProperty("asset")]
        public Asset Asset { get; set; }
    }
}
