using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Services.Interfaces;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoccerCuponsController : ControllerBase
    {
        private readonly ISoccerCuponService _soccerCuponService;

        public SoccerCuponsController(ISoccerCuponService soccerCuponService)
        {
            _soccerCuponService = soccerCuponService;
        }
        [HttpGet]
        public IActionResult GetCupon()
        {
            try
            {
                var Results = _soccerCuponService.GetCupon().ToList();
                if (Results.Any())
                {
                    return Ok(Results);
                }
                else
                {
                    return NotFound("Cupon Unavailable at the moment");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error while processing your request {ex}");
            }
        }
    }
}