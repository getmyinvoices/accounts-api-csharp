using System.Collections.Generic;
using GMI.Api.Contract;
using GMI.Api.Contract.Data;
using GMI.Api.Contract.Data.Requests;
using Newtonsoft.Json;
using RestSharp;

namespace GMI.Api
{
    public class Api : IApi
    {
        private string _baseUrl;
        private string _apiKey;
        private RestClient _client;

        public Api(string baseUrl, string apiKey)
        {
            this._baseUrl = baseUrl;
            this._apiKey = apiKey;
            this._client = new RestClient(this._baseUrl);
        }

        private RestRequest getRequest(string method, object postBody)
        {
            var request = new RestRequest(method, Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-type", "application/json");
            string body = Newtonsoft.Json.JsonConvert.SerializeObject(postBody);
            request.AddJsonBody(body);
            return request;
        }
        
        
        public bool GetApiStatus()
        {
            RestRequest request = this.getRequest("/apiStatus", new BaseRequest(this._apiKey));
            IRestResponse<ApiStatus> result = this._client.Execute<ApiStatus>(request);
            return result.Data.Success;
        }

        public IEnumerable<CompanyListElement> ListCompanies(ListCompaniesRequest request)
        {
            RestRequest restRequest = this.getRequest("/listCompanies", request);
            IRestResponse<List<CompanyListElement>> result = this._client.Execute<List<CompanyListElement>>(restRequest);
            return result.Data;
        }

        public void GetCompany()
        {
            throw new System.NotImplementedException();
        }

        public void ListDocuments()
        {
            throw new System.NotImplementedException();
        }

        public void GetDocument()
        {
            throw new System.NotImplementedException();
        }

        public void UploadDocument()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateDocument()
        {
            throw new System.NotImplementedException();
        }

        public void GetCuntries()
        {
            throw new System.NotImplementedException();
        }

        public void GetCurrencies()
        {
            throw new System.NotImplementedException();
        }

        public void AddCompany()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCompany()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCompany()
        {
            throw new System.NotImplementedException();
        }

        public void GetAttachmentList()
        {
            throw new System.NotImplementedException();
        }

        public void UploadAttachment()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAttachment()
        {
            throw new System.NotImplementedException();
        }
    }
}