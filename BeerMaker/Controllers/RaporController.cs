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
    public class RaporController : ControllerBase
    {
        private readonly ILogger<RaporController> _logger;

        public RaporController(ILogger<RaporController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> GenerateRaport(DateTime from, DateTime to, int WarehouseId,)
        {
            return null;
        }
    }
}
