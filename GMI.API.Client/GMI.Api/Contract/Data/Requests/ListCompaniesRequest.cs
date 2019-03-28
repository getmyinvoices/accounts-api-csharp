namespace GMI.Api.Contract.Data.Requests
{
    public class ListCompaniesRequest : BaseRequest
    {
        private ListCompaniesStates _states;

        public ListCompaniesRequest(string apiKey) : base(apiKey) {}
    }
}