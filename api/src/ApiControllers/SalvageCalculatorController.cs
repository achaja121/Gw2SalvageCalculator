using Microsoft.AspNetCore.Mvc;

namespace Gw2SalvageCalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalvageCalculatorController : ControllerBase
    {
        private readonly ILogger<SalvageCalculatorController> _logger;

        public SalvageCalculatorController(ILogger<SalvageCalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("hello")]
        public IActionResult Get()
        {
            _logger.LogInformation("Hello World.");

            return Ok("HelloWorld");
        }

        [HttpGet("search")]
        public IActionResult GetItemsByNameAsync(string itemName)
        {
            if (string.IsNullOrWhiteSpace(itemName))
            {
                return BadRequest("Name cannot be empty");
            }

            return Ok();
        }
    }
}