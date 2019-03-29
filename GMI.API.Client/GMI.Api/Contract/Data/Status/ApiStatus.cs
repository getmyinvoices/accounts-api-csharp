using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Status {
  /// <summary>
  /// ApiStatus is the response from the getAPIStatus request
  /// </summary>
  public class ApiStatus {
    /// <summary>
    /// Success indicates if the api is working as intended
    /// </summary>
    [JsonProperty("success")]
    public bool Success { get; set; }
    /// <summary>
    /// ctor
    /// </summary>
    public ApiStatus() {
    }
  }

}