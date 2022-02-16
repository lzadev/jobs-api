namespace Jobs.DataAccess.Extensions
{
    using Jobs.DataAccess.Abstract.UnitOfWork;
    using Jobs.DataAccess.Concret.UnitOfWork;
    using Jobs.DataAccess.Repositories.Abstract;
    using Jobs.DataAccess.Repositories.Concret;
    using Microsoft.Extensions.DependencyInjection;
    public static class RepositoriesRegister
    {
        public static void RepositoriesInject(this IServiceCollection services)
        {
            services.AddTransient<IJobRepository, JobRepository>();
            services.AddTransient<IJobTypeRepository, JobTypeRepository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
