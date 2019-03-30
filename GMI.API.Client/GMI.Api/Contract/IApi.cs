using System.Collections.Generic;
using GMI.Api.Contract.Data.Attachment;
using GMI.Api.Contract.Data.Company;
using GMI.Api.Contract.Data.Country;
using GMI.Api.Contract.Data.Currency;
using GMI.Api.Contract.Data.Document;

namespace GMI.Api.Contract {
  /// <summary>
  /// IApi is the client interface to talk with the api
  /// </summary>
  public interface IApi {
    /// <summary>
    /// Gets the API status
    /// </summary>
    /// <returns>True for success, else false</returns>
    bool GetApiStatus();
    /// <summary>
    /// Returns a list of companies using the provided filters
    /// </summary>
    /// <param name="request">Request is used to apply filers</param>
    /// <returns>A list of companies</returns>
    IEnumerable<CompanyListElement> ListCompanies(ListCompaniesRequest request);
    /// <summary>
    /// Returns the company
    /// </summary>
    /// <param name="request">Request is used to apply a filter</param>
    Company GetCompany(GetCompanyRequest request);
    /// <summary>
    /// Returns a list of documents using the provided filters
    /// </summary>
    /// <param name="request">Request is used to apply filters</param>
    void ListDocuments(ListDocumentsRequest request);
    /// <summary>
    /// Returns the searched document
    /// </summary>
    /// <param name="request">Request is used to apply filters</param>
    void GetDocument(GetDocumentRequest request);
    void UploadDocument();
    void UpdateDocument();
    /// <summary>
    /// Returns a list of countries
    /// </summary>
    /// <param name="request"></param>
    IEnumerable<Country> GetCountries(GetCountriesRequest request);
    /// <summary>
    /// Returns a list of currencies
    /// </summary>
    /// <param name="request"></param>
    void GetCurrencies(GetCurrenciesRequest request);
    void AddCompany();
    void UpdateCompany();
    void DeleteCompany();
    void GetAttachmentList(ListAttachmentsRequest request);
    void UploadAttachment();
    void DeleteAttachment();
  }
}