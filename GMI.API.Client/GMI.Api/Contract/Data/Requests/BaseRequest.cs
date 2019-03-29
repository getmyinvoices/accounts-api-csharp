using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Requests {
  public class BaseRequest {
    [JsonProperty("api_key")]
    public string ApiKey { get; set; }

    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="apiKey">key of account</param>
    public BaseRequest(string apiKey) {
      this.ApiKey = apiKey;
    }
  }
}