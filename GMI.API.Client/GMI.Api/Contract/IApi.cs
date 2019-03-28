using System.Collections.Generic;
using GMI.Api.Contract.Data;
using GMI.Api.Contract.Data.Requests;

namespace GMI.Api.Contract
{
    /// <summary>
    /// IApi is the client interface to talk with the api
    /// </summary>
    public interface IApi
    {
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
        void GetCompany();
        void GetDocuments();
        void GetDocument();
        void UploadDocument();
        void UpdateDocument();
        void GetCuntries();
        void GetCurrencies();
        void AddCompany();
        void UpdateCompany();
        void DeleteCompany();
        void GetAttachmentList();
        void UploadAttachment();
        void DeleteAttachment();
    }
}