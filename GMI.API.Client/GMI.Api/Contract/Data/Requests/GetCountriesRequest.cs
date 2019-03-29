namespace GMI.Api.Contract.Data.Requests {
  /// <summary>
  /// Used to fetch a list of countries
  /// </summary>
  public class GetCountriesRequest : BaseRequest {
    /// <inheritdoc />
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="apiKey">API key of account</param>
    public GetCountriesRequest(string apiKey) : base(apiKey) {
    }
  }
}