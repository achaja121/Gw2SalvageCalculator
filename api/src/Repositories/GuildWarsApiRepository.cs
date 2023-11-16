using Gw2SalvageCalculator.Api.ApiResponses;
using Gw2SalvageCalculator.Api.Constants;
using Gw2SalvageCalculator.Api.Interfaces;

namespace Gw2SalvageCalculator.Api.Repositories
{
    internal class GuildWarsApiRepository : HttpRepositoryBase, IGuildWarsApiRepository
    {
        private static readonly string _separator = "/";

        private readonly ILogger _logger;

        public GuildWarsApiRepository(IHttpClientFactory httpClientFactory, ILogger<GuildWarsApiRepository> logger)
            : base(httpClientFactory, logger)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<int>> GetAllItemIdsAsync()
        {
            return await SendGetRequestAsync<IEnumerable<int>>(GWApiEndpoints.ItemsEndpoint);
        }

        public async Task<ItemResponse> GetItemById(string id)
        {
            var endpoint = string.Format(GWApiEndpoints.ItemsEndpoint, _separator, id);

            return await SendGetRequestAsync<ItemResponse>(endpoint);
        }
    }
}
