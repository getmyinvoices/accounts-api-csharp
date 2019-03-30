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
    /// Initializes the request using the given key
    /// </summary>
    /// <param name="apiKey">API Key</param>
    public void Initialize(string apiKey) {
      this.ApiKey = apiKey;
    }
  }
}