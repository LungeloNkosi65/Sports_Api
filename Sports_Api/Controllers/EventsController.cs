using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Services;
//using Sports_Api.Models;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;
        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }
        [HttpGet]
        [Route("EventsForTournament")]
        public IActionResult GetEventsForTournament(int? tournamentId)
        {
            //return _eventService.GetEventForTournament(tournamentId);
            try
            {
                if (tournamentId.HasValue)
                {
                    var results = _eventService.GetEventForTournament(tournamentId).ToList();
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound("There was a problem trying to process the request. Record was not found");
                    }
                }
                else
                {
                    return BadRequest("There was a problem trying to process the request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process the request {ex}");
            }
        }
    }
}