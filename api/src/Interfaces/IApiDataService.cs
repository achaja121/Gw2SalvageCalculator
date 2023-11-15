namespace Gw2SalvageCalculator.Api.Interfaces
{
    public interface IApiDataService
    {
        Task<bool> PopulateDBWithGuildWarsDataAsync();
    }
}