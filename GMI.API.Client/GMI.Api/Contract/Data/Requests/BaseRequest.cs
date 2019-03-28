using Newtonsoft.Json;

namespace GMI.Api.Contract.Data
{
    public class BaseRequest
    {
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }

        
        public BaseRequest(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
    
}