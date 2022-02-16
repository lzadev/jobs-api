namespace Jobs.DataAccess.Models
{
    using Newtonsoft.Json;
    public class CityReponse
    {
        [JsonProperty("limit")]
        public string Limit { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("data")]
        public IEnumerable<City> Data { get; set; }
    }
}
