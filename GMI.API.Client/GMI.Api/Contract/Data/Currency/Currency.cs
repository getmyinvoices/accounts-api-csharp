using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Currency {
  /// <summary>
  /// Currency is a currency model
  /// </summary>
  public class Currency {
    [JsonProperty("name")] public string Name { get; set; }
    [JsonProperty("currency_code")] public string CurrencyCode { get; set; }

    /// <summary>
    /// ctor
    /// </summary>
    public Currency() {
    }
  }
}
