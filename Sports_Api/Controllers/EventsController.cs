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
        public EventsController (IEventService eventService)
        {
            _eventService = eventService;
        }
        [HttpGet]
        [Route("EventsForTournament")]
        public IQueryable<Event> GetEventsForTournament(int? tournamentId)
        {
            return _eventService.GetEventForTournament(tournamentId);
        }
    }
}