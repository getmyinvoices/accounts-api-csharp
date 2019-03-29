using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Country {
  /// <summary>
  /// Represents a single country
  /// </summary>
  public class Country {
    [JsonProperty("prim_uid")] public int PrimUid { get; set; }
    [JsonProperty("name")] public string Name { get; set; }
    [JsonProperty("country_code")] public string CountryCode { get; set; }
    [JsonProperty("vat")] public int Vat { get; set; }
    [JsonProperty("is_eu")] public int IsEu { get; set; }

    /// <summary>
    /// ctor is needed for serialization
    /// </summary>
    public Country() {
      
    }
  }
}
