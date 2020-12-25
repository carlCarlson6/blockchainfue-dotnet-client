using Newtonsoft.Json;
using System;

namespace BlockchainFue.Messages.CreateAsset
{
    internal class CreateAssetRequest
    {
        [JsonProperty("asset")]
        public CreateAssetRequestAsset Asset { get; set; }

        internal CreateAssetRequest(String type, dynamic assetObjectData)
        {
            this.Asset = new CreateAssetRequestAsset(type, assetObjectData);
        }
    }
}
