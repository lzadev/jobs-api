namespace Jobs.BussinessLogic.Extensions
{
    using Jobs.BussinessLogic.Services.Abstract;
    using Jobs.BussinessLogic.Services.concret;
    using Microsoft.Extensions.DependencyInjection;
    public static class ServicesRegister
    {
        public static void ServicesInject(this IServiceCollection services)
        {
            services.AddTransient<ICityService, CityService>();


            //AutoMapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
