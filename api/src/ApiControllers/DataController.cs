using Gw2SalvageCalculator.Api.Interfaces;
using Gw2SalvageCalculator.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Gw2SalvageCalculator.Api.ApiControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly IApiDataService _apiDataService;
        private readonly ILogger _logger;

        public DataController(IApiDataService apiDataService, ILogger<DataController> logger)
        {
            _apiDataService = apiDataService;
            _logger = logger;
        }

        [HttpPost("populate")]
        public async Task<IActionResult> PopulateDataAsync()
        {
            var result = await _apiDataService.PopulateDBWithGuildWarsDataAsync();

            return result ? Ok() : StatusCode(500);
        }
    }
}
