namespace GMI.Api.Contract.Data.Requests {
  /// <summary>
  /// Used to fetch a list of currencies
  /// </summary>
  public class GetCurrenciesRequest : BaseRequest {
    /// <inheritdoc />
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="apiKey">API key of account</param>
    public GetCurrenciesRequest(string apiKey) : base(apiKey) {
    }
  }
}