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
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> GetItems()
        {
            return null;
        }
        public async Task<IActionResult> GetItem(Guid uuid)
        {
            return null;
        }
        public async Task<IActionResult> AddItem([FromBody] Client item)
        {
            return null;
        }
        public async Task<IActionResult> UpdateItem(Guid uuid, [FromBody] Client item)
        {
            return null;
        }

        public async Task<IActionResult> DeleteItem(Guid uuid)
        {
            return null;
        }
    }
}
