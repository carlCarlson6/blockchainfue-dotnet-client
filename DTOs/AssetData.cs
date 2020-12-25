using Newtonsoft.Json;

namespace BlockchainFue.DTOs
{
    // TODO - habran cambios aqui
    public class AssetData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("assetObjectData")]
        public dynamic AssetObjectData { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("token")]
        public bool Token { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }

    }
}