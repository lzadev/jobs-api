namespace Jobs.DataAccess.Repositories.Concret
{
    using Jobs.DataAccess.Models;
    using Jobs.DataAccess.Repositories.Abstract;
    using System.Text.Json;

    public class CityRepository : ICityRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _options;

        public CityRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<CityReponse> GetAllCities()
        {
            var httpClient = _httpClientFactory.CreateClient("CitiesAPI");

            using var response = await httpClient.GetAsync("cities?limit=32", HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();

            var cities = await JsonSerializer.DeserializeAsync<CityReponse>(stream, _options);

            return cities!;
        }
    }
}
