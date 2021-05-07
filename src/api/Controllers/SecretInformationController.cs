using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecretInformationController : ControllerBase
    {

        private readonly ILogger<SecretInformationController> _logger;
        private readonly IConfiguration _configuration;

        public SecretInformationController(ILogger<SecretInformationController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            return _configuration["SecretInformation"];
        }
    }
}
