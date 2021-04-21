using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BeerMaker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<ReportController> _logger;

        public ReportController(ILogger<ReportController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> GenerateReport(DateTime from, DateTime to, int WarehouseId)
        {
            return null;
        }
    }
}
