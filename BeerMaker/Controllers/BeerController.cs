using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerMaker.Models;
using BeerMaker.Params;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BeerMaker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeerController : ControllerBase
    {
        private readonly ILogger<BeerController> _logger;

        public BeerController(ILogger<BeerController> logger)
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

        public async Task<IActionResult> GetItemFilter(BeerSearchParams beerSearchParams)
        {
            return null;
        }

        public async Task<IActionResult> AddItem([FromBody] Beer item)
        {
            return null;
        }
        public async Task<IActionResult> UpdateItem(int ID, [FromBody] Beer item)
        {
            return null;
        }

        public async Task<IActionResult> DeleteItem(int ID)
        {
            return null;
        }
        public async Task<IActionResult> AddPicture(Guid uuid)
        {
            return null;
        }
        public async Task<IActionResult> DeletePicture(Guid uuid)
        {
            return null;
        }
    }
}
