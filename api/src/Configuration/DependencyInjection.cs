using Gw2SalvageCalculator.Api.Interfaces;
using Gw2SalvageCalculator.Api.Repositories;

namespace Gw2SalvageCalculator.Api.Configuration
{
    public  static class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IGuildWarsApiRepository, GuildWarsApiRepository>();
            services.AddScoped<IApiDataService, IApiDataService>();
            services.AddScoped<IItemService, IItemService>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}
