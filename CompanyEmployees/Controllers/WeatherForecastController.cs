using Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CompanyEmployees.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private ILoggerManager _logger;
        private readonly IRepositoryManager _repository;
        public WeatherForecastController(ILoggerManager logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is info message from our values controller.");
            _logger.LogDebug("Here is debug message from our values controller.");
            _logger.LogWarn("Here is warn message from our values controller.");
            _logger.LogError("Here is an error message from our values controller.");

            return new string[] { "value1", "value2" };
        }
    }
}
