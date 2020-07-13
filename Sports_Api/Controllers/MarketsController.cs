using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Repository;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketsController : ControllerBase
    {
        private readonly IMarketService _marketService;
        public MarketsController(IMarketService marketService)
        {
            _marketService = marketService;
        }
        [HttpGet]
        public IActionResult Get(int? betTypeId)
        {
            //return _marketService.GetMarketsForBetType(betTypeId);
            try
            {
                if (betTypeId.HasValue)
                {
                    var results = _marketService.GetMarketsForBetType(betTypeId).ToList();
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound($"Records with id: {betTypeId} were not found");
                    }
                }
                else
                {
                    return BadRequest($"There was an error trying to process the request");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error trying to process the request {ex}");
            }
        }
    }
}