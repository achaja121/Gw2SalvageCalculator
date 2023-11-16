using Gw2SalvageCalculator.Api.Interfaces;
using Gw2SalvageCalculator.Api.Repositories;
using Gw2SalvageCalculator.Api.Services;

namespace Gw2SalvageCalculator.Api.Configuration
{
    public  static class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddScoped<IGuildWarsApiRepository, GuildWarsApiRepository>();
            services.AddScoped<IApiDataService, ApiDataService>();
            services.AddScoped<IItemService, ItemService>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}
