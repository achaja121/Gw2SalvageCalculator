using Gw2SalvageCalculator.DataAccess.Constants;
using Gw2SalvageCalculator.DataAccess.Interfaces;
using Gw2SalvageCalculator.DataAccess.Models;

namespace Gw2SalvageCalculator.DataAccess.Repositories
{
    internal class ItemsRepository
    {
        private readonly ISqlDataAccess _db;

        public ItemsRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<bool> AddAsync(IEnumerable<ItemModel> items)
        {
            return await _db.InsertDataAsync(DataAccessConstants.InsertItemsSP, items) > 0;
        }

        public async Task<IEnumerable<ItemModel>> GetItemsByIdAsync(int id)
        {
            return await _db.GetDataAsync<ItemModel, dynamic>(DataAccessConstants.GetItemByIdSP, new { id });
        }

        public async Task<IEnumerable<ItemModel>> GetItemsByNameAsync(string name)
        {
            return await _db.GetDataAsync<ItemModel, dynamic>(DataAccessConstants.GetItemsByNameSP, new {name});
        }
    }
}
