using Microsoft.AspNetCore.Mvc;

namespace Gw2SalvageCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
            return Ok("HelloWorld");
        }
    }
}