namespace Jobs.DataAccess.Extensions
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Net.Http.Headers;
    using System.Net.Http.Headers;

    public static class HttpClientRegister
    {
        public static void HttpClientsInject(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("CitiesAPI", config =>
            {
                config.BaseAddress = new Uri(configuration["UrlAPIs:CitiesAPIUrl"]);
                config.Timeout = new TimeSpan(0, 0, 60);
                config.DefaultRequestHeaders.Clear();
                config.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            });
        }
    }
}
