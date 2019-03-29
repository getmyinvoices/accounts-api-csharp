using GMI.Api.Contract.Data.Requests;
using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Company {
  /// <summary>
  /// Request used to fetch a single company
  /// </summary>
  public class GetCompanyRequest : BaseRequest {
    /// <summary>
    /// ID of the company
    /// </summary>
    [JsonProperty("company_id")]
    public int CompanyId { get; private set; }

    /// <inheritdoc />
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="apiKey">API key of account</param>
    /// <param name="companyId">PRIM_UID of the company.</param>
    public GetCompanyRequest(string apiKey, int companyId) : base(apiKey) {
      this.CompanyId = companyId;
    }
  }
}