using EmailingList.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace EmailingList.MVC.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
