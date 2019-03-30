using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using GMI.Api.Contract;
using GMI.Api.Contract.Data.Company;
using GMI.Api.Contract.Data.Country;

namespace GMI.Api.Test
{
    [TestClass]
    public class ApiTests
    {
        private static IApi _client;
        private const string Url = "https://api.getmyinvoices.com/accounts/v2";

        [ClassInitialize] 
        public static void Initialize(TestContext testContext)
        {
            string secret = Environment.GetEnvironmentVariable("GMI_API_KEY");
            ApiTests._client = new Client(Url, secret);
        }

        [TestMethod]
        public void AddCompany()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void DeleteAttachment()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void DeleteCompany()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void GetApiStatus()
        {           
            bool status = _client.GetApiStatus();
            Assert.IsTrue(status);
        }

        [TestMethod]
        public void GetAttachmentList()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void ListCompanies()
        {            
            IEnumerable<CompanyListElement> result = _client.ListCompanies(new ListCompaniesRequest());
        }

        [TestMethod]
        public void GetCompany() {
          Company result = _client.GetCompany(new GetCompanyRequest(1234));
        }

        [TestMethod]
        public void GetCountries()
        {
            _client.GetCountries(new GetCountriesRequest());
        }

        [TestMethod]
        public void GetCurrencies()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void GetDocument()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void GetDocuments()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void UpdateCompany()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void UpdateDocument()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void UploadAttachment()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void UploadDocument()
        {
            throw new System.NotImplementedException();
        }
    }
}