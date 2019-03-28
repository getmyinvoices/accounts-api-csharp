using Newtonsoft.Json;

namespace GMI.Api.Contract.Data
{
    public class CompanyListElement
    {
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

        public CompanyListElement()
        {
        }
    }
}