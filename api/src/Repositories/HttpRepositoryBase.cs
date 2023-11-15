using Gw2SalvageCalculator.Api.Constants;
using Newtonsoft.Json;

namespace Gw2SalvageCalculator.Api.Repositories
{
    internal abstract class HttpRepositoryBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private ILogger _logger;

        protected HttpRepositoryBase(IHttpClientFactory httpClientFactory, ILogger logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        protected async Task<T> SendGetRequestAsync<T>(string requestUri)
        {
            var client = CreateClient();
            var response = await client.GetAsync(requestUri);

            var content = await response?.Content?.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                if (string.IsNullOrEmpty(content))
                {
                    _logger.LogError($"{nameof(HttpRepositoryBase)}: Get request to {requestUri} did not return content");

                    return default;
                }

                return JsonConvert.DeserializeObject<T>(content);
            }
            
            _logger.LogError($"{nameof(HttpRepositoryBase)}: Get request to {requestUri} failed, {response.StatusCode}, {content}");

            return default;
        }

        private HttpClient CreateClient()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(GWApiEndpoints.BaseUrl);

            return client;
        }
    }
}
