using Gw2SalvageCalculator.Api.ApiResponses;
using Gw2SalvageCalculator.Api.Interfaces;

namespace Gw2SalvageCalculator.Api.Services
{
    internal class ApiDataService : IApiDataService
    {
        private readonly IGuildWarsApiRepository _guildWarsApiRepository;
        private readonly ILogger _logger;

        public ApiDataService(IGuildWarsApiRepository guildWarsApiRepository, ILogger<ApiDataService> logger)
        {
            _guildWarsApiRepository = guildWarsApiRepository;
            _logger = logger;
        }

        public async Task<bool> PopulateDBWithGuildWarsDataAsync()
        {
            var itemResponses = new List<ItemResponse>();
            var itemIds = (await _guildWarsApiRepository.GetAllItemIdsAsync()).ToList();
            var batches = SplitList(itemIds);

            foreach (var batch in batches)
            {
                var tasks = batch.Select(id => _guildWarsApiRepository.GetItemById(id.ToString()));
                var items = await Task.WhenAll(tasks);
                itemResponses.AddRange(items);
            }

            var x = itemResponses;

            return true;
        }

        private static IEnumerable<List<int>> SplitList(List<int> orginalList, int nSize = 300)
        {
            var batches = new List<List<int>>();

            for (int i = 0; i < orginalList.Count; i += nSize)
            {
                batches.Add(orginalList.GetRange(i, Math.Min(nSize, orginalList.Count - i)));
            }

            return batches;
        }
    }
}
