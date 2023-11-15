using Gw2SalvageCalculator.Api.ApiResponses;

namespace Gw2SalvageCalculator.Api.Interfaces
{
    internal interface IGuildWarsApiRepository
    {
        Task<IEnumerable<int>> GetAllItemIdsAsync();
        Task<ItemResponse> GetItemById(string id);
    }
}