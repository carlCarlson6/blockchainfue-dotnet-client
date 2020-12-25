using Newtonsoft.Json;
using System;

namespace BlockchainFue.Messages.DeleteAsset
{
    internal class DeleteAssetResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("msg")]
        public String Message { get; set; }
    }
}
