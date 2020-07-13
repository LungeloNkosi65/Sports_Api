using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Odd_sController : ControllerBase
    {
        private readonly IOddsService _oddsService;

        public Odd_sController(IOddsService oddsService)
        {
            _oddsService = oddsService;
        }
       // Odd_sGetOddsForEvent
         [HttpGet]
        public IActionResult GetOddsForEvent(int ? tournamentId)
        {
            try
            {
                if (tournamentId.HasValue)
                {
                    var result = _oddsService.GetOddsForEvent(tournamentId).ToList();
                    if (result.Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound("REcords not found");
                    }
                }
                else
                {
                    return BadRequest("Invalid parameter passed");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error trying to process the requst {ex}");
            }
        }

    }
}