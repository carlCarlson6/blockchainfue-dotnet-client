using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockchainFue.Messages.AppendAsset
{
    internal class AppendAssetResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("msg")]
        public String Message { get; set; }

    }
}
