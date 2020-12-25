using BlockchainFue.Common;
using BlockchainFue.DTOs;
using BlockchainFue.Messages.AppendAsset;
using BlockchainFue.Messages.CreateAsset;
using BlockchainFue.Messages.DeleteAsset;
using BlockchainFue.Messages.HistoryAsset;
using BlockchainFue.Messages.RetrieveAsset;
using BlockchainFue.Messages.RetriveAsset;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlockchainFue
{
    public class BlockchainClient
    {
        private readonly HttpClient http = new HttpClient();

        public BlockchainClient(String publicKey, String privateKey, String appId, String appKey)
        {
            this.http.DefaultRequestHeaders.Add("X-Public-Key", publicKey);
            this.http.DefaultRequestHeaders.Add("X-Private-Key", privateKey);         
            this.http.DefaultRequestHeaders.Add("X-App-Id", appId);
            this.http.DefaultRequestHeaders.Add("X-App-Key", appKey);
            this.http.DefaultRequestHeaders.Add("Accept", BlockchainConstants.ACCEPT);
        }

        public async Task<String> CreateAssetAsync(String type, dynamic assetObject)
        {
            HttpContent requestContent = HttpHelper.SerializeRequestContent(new CreateAssetRequest(type, assetObject));
            HttpResponseMessage httpResponse = await this.http.PostAsync(BlockchainConstants.BASE_URL + BlockchainConstants.ASSET, requestContent);
            CreateAssetResponse createAssetResponse = await HttpHelper.DeserializeHttpResponse<CreateAssetResponse>(httpResponse);

            if(!createAssetResponse.Ok)
            {
                throw new Exception();
            }

            return createAssetResponse.Id;
        }

        public async Task<List<Asset>> RetriveAssetAsync()
        {
            HttpResponseMessage httpResponse = await this.http.GetAsync(BlockchainConstants.BASE_URL + BlockchainConstants.ASSET);
            RetriveAllAssetsResponse retrieveAllResponse = await HttpHelper.DeserializeHttpResponse<RetriveAllAssetsResponse>(httpResponse);
            return retrieveAllResponse.Assets;
        }

        public async Task<List<Asset>> ExecuteQuery(String query)
        {
            throw new NotImplementedException();
        }

        public async Task<Asset> RetriveAssetAsync(String hashId)
        {
            String queryStr = JsonConvert.SerializeObject(new { id = hashId });
            HttpResponseMessage httpResponse = await this.http.GetAsync(BlockchainConstants.BASE_URL + BlockchainConstants.ASSET + BlockchainConstants.QUERY + queryStr);
            RetrieveAssetResponse retrieveAssetResponse = await HttpHelper.DeserializeHttpResponse<RetrieveAssetResponse>(httpResponse);
            return retrieveAssetResponse.Asset;
        }

        public async Task<List<AssetHistory>> RetriveAssetHistoryAsync(String hashId)
        {
            String queryStr = JsonConvert.SerializeObject(new { id = hashId });
            HttpResponseMessage httpResponse = await this.http.GetAsync(BlockchainConstants.BASE_URL + BlockchainConstants.ASSETHISTORY + BlockchainConstants.QUERY + queryStr);
            RetrieveAssetHistoryResponse assetHistoryResponse = await HttpHelper.DeserializeHttpResponse<RetrieveAssetHistoryResponse>(httpResponse);
            return assetHistoryResponse.History;
        }

        public async Task<Boolean> AppendAssetAsync(String hashId, dynamic metadataObject, String to = null)
        {
            HttpContent requestContent = HttpHelper.SerializeRequestContent(new AppendAssetRequest(hashId, metadataObject, to));
            HttpResponseMessage httpResponse = await this.http.PutAsync(BlockchainConstants.BASE_URL + BlockchainConstants.ASSET, requestContent);
            AppendAssetResponse appendAssetResponse = await HttpHelper.DeserializeHttpResponse<AppendAssetResponse>(httpResponse);
            return appendAssetResponse.Ok;
        }

        public async Task<Boolean> BurnAssetAsync(String hashId)
        {
            String queryStr = JsonConvert.SerializeObject(new { id = hashId });
            HttpResponseMessage httpResponse = await this.http.DeleteAsync(BlockchainConstants.BASE_URL + BlockchainConstants.ASSET + BlockchainConstants.QUERY + queryStr);
            DeleteAssetResponse deleteAssetResponse = await HttpHelper.DeserializeHttpResponse<DeleteAssetResponse>(httpResponse);
            return deleteAssetResponse.Ok;
        }

    }
}
