using BlockchainFue.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockchainFue.Messages.HistoryAsset
{
    internal class RetrieveAssetHistoryResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("msg")]
        public String Message { get; set; }

        [JsonProperty("history")]
        public List<AssetHistory> History{ get; set; }
    }
}
