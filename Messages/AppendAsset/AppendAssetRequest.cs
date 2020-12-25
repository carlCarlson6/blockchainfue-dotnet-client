using Newtonsoft.Json;
using System;

namespace BlockchainFue.Messages.AppendAsset
{
    internal class AppendAssetRequest
    {
        [JsonProperty("id")]
        public String HashId { get; set; }
        
        [JsonProperty("metadata")]
        public dynamic Metadata { get; set; }

        [JsonProperty("to")]
        public String To { get; set; }


        public AppendAssetRequest(String hashId, dynamic metadataObject, String to)
        {
            this.HashId = hashId;
            this.Metadata = new { assetObjectMetadata = metadataObject };
            this.To = to;
        }
    }
}
