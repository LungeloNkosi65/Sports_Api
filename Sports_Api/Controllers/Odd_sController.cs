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
        public IQueryable<CustomOdds>GetOddsForEvent(int ? tournamentId)
        {
            return _oddsService.GetOddsForEvent(tournamentId);
        }

    }
}