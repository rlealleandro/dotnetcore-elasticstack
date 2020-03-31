using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ElasticStack.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogSampleController : ControllerBase
    {
        ILogger<LogSampleController> _logger;

        public LogSampleController(ILogger<LogSampleController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("logInfo")]
        public IActionResult LogInfo()
        {
            try
            {
                _logger.LogInformation($"Log information: {DateTime.UtcNow}");
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("logWarning")]
        public IActionResult LogWarning()
        {
            try
            {
                _logger.LogWarning($"Log warning: {DateTime.UtcNow}");
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("logError")]
        public IActionResult LogError()
        {
            try
            {
                _logger.LogError($"Log error: {DateTime.UtcNow}");
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}