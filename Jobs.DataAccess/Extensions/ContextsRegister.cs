namespace Jobs.DataAccess.Extensions
{
    using Jobs.DataAccess.Contexts;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    public static class ContextsRegister
    {
        public static void ContextsInject(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<JobContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("jobsConnection")));
        }
    }
}
