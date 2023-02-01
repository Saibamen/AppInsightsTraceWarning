﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace AppInsightsTraceWarning.Controllers
{
    [ApiController]
    [Route("api")]
    public class ConfigurationController : Controller
    {
        [HttpGet("version")]
        public IActionResult Version()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            return Ok(new VersionModel
            {
                Environment = environment,
                Info = "Without Serilog (deleted all Serilog packages and code)",
            });
        }
    }

    public class VersionModel
    {
        /// <summary>
        /// ASPNETCORE_ENVIRONMENT environment variable
        /// </summary>
        public string Environment { get; set; }
        public string Info { get; set; }
    }
}
