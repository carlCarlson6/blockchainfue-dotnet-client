using Newtonsoft.Json;

namespace BlockchainFue.Messages.CreateAsset
{
    internal class CreateAssetRequestAsset
    {
        [JsonProperty("data")]
        public CreateAssetRequestAssetData Data { get; set; }

        public CreateAssetRequestAsset(string type, dynamic assetObjectData)
        {
            this.Data = new CreateAssetRequestAssetData(type, assetObjectData);
        }
    
    }
}
