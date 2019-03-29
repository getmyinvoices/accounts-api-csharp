using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Company {
  /// <summary>
  /// Model of a company
  /// </summary>
  public class Company {
    [JsonProperty("prim_uid")]
    public int PrimUid { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("company_type")]
    public string CompanyType { get; set; }
    [JsonProperty("note")]
    public string Note { get; set; }
    [JsonProperty("tags")]
    public string Tags { get; set; }
    [JsonProperty("street")]
    public string Street { get; set; }
    [JsonProperty("zip")]
    public string Zip { get; set; }
    [JsonProperty("city")]
    public string City { get; set; }
    [JsonProperty("email")]
    public string Email { get; set; }
    [JsonProperty("phone")]
    public string Phone { get; set; }
    [JsonProperty("fax")]
    public string Fax { get; set; }
    [JsonProperty("tax_number")]
    public string TaxNumber { get; set; }
    [JsonProperty("vat_id")]
    public string VatId { get; set; }
    [JsonProperty("commercial_register")]
    public string CommercialRegister { get; set; }
    [JsonProperty("iban")]
    public string Iban { get; set; }
    [JsonProperty("bic")]
    public string Bic { get; set; }
    [JsonProperty("url")]
    public string Url { get; set; }


    /// <summary>
    /// ctor
    /// </summary>
    public Company() {
    }
  }
}
