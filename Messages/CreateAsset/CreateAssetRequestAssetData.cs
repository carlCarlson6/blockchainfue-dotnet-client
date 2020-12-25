using Newtonsoft.Json;
using System;

namespace BlockchainFue.Messages.CreateAsset
{
    // TODO - pendiente cambiar estrucutra de la clase para que todos campos del objeto vayan dentro
    // tal vez cambiar la logica cuando en el BlockchainClient
    internal class CreateAssetRequestAssetData
    {
        [JsonProperty("type")]
        public String Type { get; set; }

        [JsonProperty("assetObjectData")]
        public dynamic AssetObjectData { get; set; }

        public CreateAssetRequestAssetData(string type, dynamic assetObjectData)
        {
            Type = type;
            AssetObjectData = assetObjectData;
        }
    }
}