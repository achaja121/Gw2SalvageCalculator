using Microsoft.AspNetCore.Mvc;

namespace Gw2SalvageCalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalvageCalculator : ControllerBase
    {
        private readonly ILogger<SalvageCalculator> _logger;

        public SalvageCalculator(ILogger<SalvageCalculator> logger)
        {
            _logger = logger;
        }

        [HttpGet("hello")]
        public IActionResult Get()
        {
            _logger.LogInformation("Hello World.");

            return Ok("HelloWorld");
        }
    }
}