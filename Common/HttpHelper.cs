using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlockchainFue.Common
{
    internal class HttpHelper
    {
        public static HttpContent SerializeRequestContent(object request)
        {
            String requestJson = JsonConvert.SerializeObject(request);
            HttpContent requestContent = new StringContent(requestJson, System.Text.Encoding.UTF8, "application/json");
            return requestContent;
        }

        public static async Task<T> DeserializeHttpResponse<T>(HttpResponseMessage response)
        {
            String result = await response.Content.ReadAsStringAsync();
            T deserializedResponse = JsonConvert.DeserializeObject<T>(result);
            return deserializedResponse;
        }
    }
}
