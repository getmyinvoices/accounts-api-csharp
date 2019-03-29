using System.Collections.Generic;
using GMI.Api.Contract;
using GMI.Api.Contract.Data.Attachment;
using GMI.Api.Contract.Data.Company;
using GMI.Api.Contract.Data.Country;
using GMI.Api.Contract.Data.Currency;
using GMI.Api.Contract.Data.Document;
using GMI.Api.Contract.Data.Requests;
using GMI.Api.Contract.Data.Status;
using RestSharp;

namespace GMI.Api {
  /// <summary>
  /// Client Client
  /// </summary>
  public class Client : IApi {
    private readonly string _apiKey;
    private readonly RestClient _client;

    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="baseUrl">baseURL from the api</param>
    /// <param name="apiKey">the api key</param>
    public Client(string baseUrl, string apiKey) {
      this._apiKey = apiKey;
      this._client = new RestClient(baseUrl);
    }

    private RestRequest getRequest(string method, object postBody) {
      var request = new RestRequest(method, Method.POST);
      request.AddHeader("Accept", "application/json");
      request.AddHeader("Content-type", "application/json");
      string body = Newtonsoft.Json.JsonConvert.SerializeObject(postBody);
      request.AddJsonBody(body);
      return request;
    }


    /// <inheritdoc />
    public bool GetApiStatus() {
      RestRequest request = getRequest("/apiStatus", new BaseRequest(this._apiKey));
      IRestResponse<ApiStatus> result = this._client.Execute<ApiStatus>(request);
      return result.Data.Success;
    }

    /// <inheritdoc />
    public IEnumerable<CompanyListElement> ListCompanies(ListCompaniesRequest request) {
      RestRequest restRequest = getRequest("/listCompanies", request);
      IRestResponse<List<CompanyListElement>> result = this._client.Execute<List<CompanyListElement>>(restRequest);
      return result.Data;
    }

    /// <inheritdoc />
    public Company GetCompany(GetCompanyRequest request) {
      RestRequest restRequest = getRequest("/getCompany", request);
      IRestResponse<Company> result = this._client.Execute<Company>(restRequest);
      return result.Data;
    }
    /// <inheritdoc />
    public void ListDocuments(ListDocumentsRequest request) {
      throw new System.NotImplementedException();
    }
    /// <inheritdoc />
    public void GetDocument(GetDocumentRequest request) {
      throw new System.NotImplementedException();
    }
    /// <inheritdoc />
    public void UploadDocument() {
      throw new System.NotImplementedException();
    }
    /// <inheritdoc />
    public void UpdateDocument() {
      throw new System.NotImplementedException();
    }
    /// <inheritdoc />
    public IEnumerable<Country> GetCountries(GetCountriesRequest request) {
      RestRequest restRequest = getRequest("/listCompanies", request);
      IRestResponse<List<Country>> result = this._client.Execute<List<Country>>(restRequest);
      return result.Data;
    }
    /// <inheritdoc />
    public void GetCurrencies(GetCurrenciesRequest request) {
      throw new System.NotImplementedException();
    }
    /// <inheritdoc />
    public void AddCompany() {
      throw new System.NotImplementedException();
    }
    /// <inheritdoc />
    public void UpdateCompany() {
      throw new System.NotImplementedException();
    }
    /// <inheritdoc />
    public void DeleteCompany() {
      throw new System.NotImplementedException();
    }
    /// <inheritdoc />
    public void GetAttachmentList(ListAttachmentsRequest request) {
      RestRequest restRequest = getRequest("/listAttachments", request);
      IRestResponse<List<Country>> result = this._client.Execute<List<Country>>(restRequest);
    }
    /// <inheritdoc />
    public void UploadAttachment() {
      throw new System.NotImplementedException();
    }
    /// <inheritdoc />
    public void DeleteAttachment() {
      throw new System.NotImplementedException();
    }
  }
}