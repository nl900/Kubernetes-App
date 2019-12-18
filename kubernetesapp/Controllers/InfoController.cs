using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KubernetesApp.Models;

namespace KubernetesApp.Controllers
{
    [ApiController]
    [Route("")]
    public class InfoController : ControllerBase
    {
        private readonly ILogger<InfoController> _logger;

        public InfoController(ILogger<InfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Information GetInfo()
        {
            return new Information { AppEnvironment = GetEnvironmentVariable("APPENVIRONMENT"), AppHost = GetEnvironmentVariable("APPHOST") };
        }

        private string GetEnvironmentVariable(string name)
        {
            _logger.LogInformation($"Getting environment variable '{name}'.");
            return Environment.GetEnvironmentVariable(name.ToLower()) ?? Environment.GetEnvironmentVariable(name.ToUpper());
        }
    }
}