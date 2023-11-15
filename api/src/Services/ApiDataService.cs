using Gw2SalvageCalculator.Api.ApiResponses;
using Gw2SalvageCalculator.Api.Interfaces;

namespace Gw2SalvageCalculator.Api.Services
{
    internal class ApiDataService : IApiDataService
    {
        private readonly IGuildWarsApiRepository _guildWarsApiRepository;
        private readonly ILogger _logger;

        public ApiDataService(IGuildWarsApiRepository guildWarsApiRepository, ILogger logger)
        {
            _guildWarsApiRepository = guildWarsApiRepository;
            _logger = logger;
        }

        public async Task<bool> PopulateDBWithGuildWarsDataAsync()
        {
            var itemResponses = new List<ItemResponse>();
            var itemIds = await _guildWarsApiRepository.GetAllItemIdsAsync();
            var taskList = itemIds.Select(x => _guildWarsApiRepository.GetItemById(x.ToString())).ToList();
            var batches = SplitList(taskList);

            foreach (var batch in batches)
            {
                var items = await Task.WhenAll(batch);
                itemResponses.AddRange(items);
            }

            var x = itemResponses;

            return true;
        }

        private static IEnumerable<List<Task<ItemResponse>>> SplitList(List<Task<ItemResponse>> orginalList, int nSize = 300)
        {
            var batches = new List<List<Task<ItemResponse>>>();

            for (int i = 0; i < orginalList.Count; i += nSize)
            {
                batches.Add(orginalList.GetRange(i, Math.Min(nSize, orginalList.Count - i)));
            }

            return batches;
        }
    }
}
