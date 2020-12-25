using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockchainFue.Messages.CreateAsset
{
    internal class CreateAssetResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }
        
        [JsonProperty("msg")]
        public String Message { get; set; }

        [JsonProperty("id")]
        public String Id { get; set; }

    }
}
