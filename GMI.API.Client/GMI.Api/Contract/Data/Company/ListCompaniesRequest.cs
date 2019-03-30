using GMI.Api.Contract.Data.Requests;
using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Company {
  /// <summary>
  /// Request used to fetch a filtered company list
  /// </summary>
  public class ListCompaniesRequest : BaseRequest {


    /// <summary>
    /// Used to filter for status
    /// </summary>
    [JsonProperty("status_filter")]
    public ListCompaniesStates State { get; private set; }

    /// <summary>
    /// Possible values: 0 = Any, ONLINE_PORTAL = Online-Portal only, CUSTOM_COMPANY = Custom company only
    /// </summary>
    [JsonProperty("company_type_filter")]
    public string CompanyTypeFilter { get; private set; }

    /// <inheritdoc />
    /// <summary>
    /// ctor
    /// </summary>
    public ListCompaniesRequest() {
      this.State = ListCompaniesStates.Any;
      this.CompanyTypeFilter = "0";
    }

    /// <inheritdoc />
    /// <summary>
    /// ctor with filter parameters
    /// </summary>
    /// <param name="state"></param>
    /// <param name="companyTypeFilter">Possible values: 0 = Any, ONLINE_PORTAL = Online-Portal only, CUSTOM_COMPANY = Custom company only</param>
    public ListCompaniesRequest(ListCompaniesStates state, CompanyTypeFilters companyTypeFilter) {
      this.State = state;

      switch (companyTypeFilter) {
        case CompanyTypeFilters.OnlinePortal: {
            this.CompanyTypeFilter = "ONLINE_PORTAL";
            break;
          }
        case CompanyTypeFilters.CustomCompany: {
            this.CompanyTypeFilter = "CUSTOM_COMPANY";
            break;
          }
        default: {
            this.CompanyTypeFilter = "0";
            break;
          }
      }
    }
  }
}