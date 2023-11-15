namespace Gw2SalvageCalculator.DataAccess.Interfaces
{
    internal interface ISqlDataAccess
    {
        Task<IEnumerable<T>> GetDataAsync<T, U>(string storedProcedure, U parameters);
        Task<int> InsertDataAsync<T>(string storedProcedure, T parameters);
    }
}