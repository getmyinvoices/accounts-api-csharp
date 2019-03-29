using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Status
{
    public class ApiStatus
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        public ApiStatus()
        {
        }    
    }
    
}