using API_MVC.Repositories.Implementations;
using API_MVC.Repositories.Interfaces;

namespace API_MVC.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<ICadAnimalRepository, CadAnimalRepository>();
            return services;
        }
    }
}
