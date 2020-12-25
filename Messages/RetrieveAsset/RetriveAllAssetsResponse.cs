using BlockchainFue.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BlockchainFue.Messages.RetriveAsset
{
    internal class RetriveAllAssetsResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("msg")]
        public String Message { get; set; }

        [JsonProperty("assets")]
        public List<Asset> Assets { get; set; }
    }
}
