using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sports_Api.Services;
//using Sports_Api.Models;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly ILogger<EventsController> _logger;
        public EventsController(IEventService eventService,ILogger<EventsController> logger)
        {
            _eventService = eventService;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get(int?eventId)
        {
            try
            {
                if (eventId.HasValue)
                {
                    var results = _eventService.GetSingleEvent(eventId).ToList();
                    if (results.Any())
                    {
                        _eventService.GetSingleEvent(eventId);
                        return Ok(results);
                    }
                    else { return NotFound("Record was not found"); }
                }
                else
                {
                    return BadRequest($"There was an error processing your requst");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error trying to process your request {ex}");
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var results = _eventService.GetAllVm().ToList();
                if (results.Any())
                {
                    return Ok(results);
                }
                else
                {

                    return NotFound("There were no records found");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error processing your request {ex}");
            }       
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

        [HttpPost]
        public IActionResult Create(Event model)
        {
            try
            {
                if (model != null)
                {
                    _logger.LogInformation("Post Request Successfull on Events Tabele");
                    _eventService.Add(model);
                    return Ok(model);
                }
                else
                {
                    return BadRequest("There was an error trying to process your request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error processing your request {ex}");
            }
        }

        [HttpPut]
        public IActionResult Update(int? eventId, [FromBody] Event model)
        {
            try
            {
                if(eventId.HasValue && model != null && eventId==model.EventId)
                {
                    _logger.LogInformation($"Record with id {eventId} successfully updated");
                    _eventService.Update(model);
                    return Ok("Record successfully updated");
                }
                else
                {
                    return BadRequest("There was an erroro teying to process your request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process your request {ex}");
            }
        }

        [HttpDelete]
        public IActionResult Delete(int ? eventId)
        {
            try
            {
                if (eventId.HasValue)
                {
                    _logger.LogInformation($"Event with id {eventId} successfully deleted");
                    _eventService.Delete(eventId);
                    return Ok("Record successfully deleted");
                }
                else
                {
                    return BadRequest("There was an error processing the request");
                }
            }
            catch (Exception ex)
            {

              return  BadRequest($"There was an error processing the request {ex}");
            }
        }
    }
}