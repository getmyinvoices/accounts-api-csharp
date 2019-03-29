using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Requests {
  /// <summary>
  /// BaseRequest
  /// </summary>
  public class BaseRequest {
    /// <summary>
    /// API Key
    /// </summary>
    [JsonProperty("api_key")]
    public string ApiKey { get; set; }

    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="apiKey">API key of account</param>
    public BaseRequest(string apiKey) {
      this.ApiKey = apiKey;
    }
  }
}