using Newtonsoft.Json;

namespace Jobs.DataAccess.Models
{
    public class City
    {
        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("surface")]
        public string Surface { get; set; }

        [JsonProperty("population")]
        public string Population { get; set; }

        [JsonProperty("density")]
        public string Density { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
