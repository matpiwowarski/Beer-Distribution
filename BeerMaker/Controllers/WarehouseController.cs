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
    public class WarehouseController : ControllerBase
    {
        private readonly ILogger<WarehouseController> _logger;

        public WarehouseController(ILogger<WarehouseController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> GetItems()
        {
            return null;
        }
        public async Task<IActionResult> GetItem(int ID)
        {
            return null;
        }
        public async Task<IActionResult> AddItem([FromBody] Warehouse item)
        {
            return null;
        }
        public async Task<IActionResult> UpdateItem(int ID, [FromBody] Warehouse item)
        {
            return null;
        }

        public async Task<IActionResult> DeleteItem(int ID)
        {
            return null;
        }
    }
}
