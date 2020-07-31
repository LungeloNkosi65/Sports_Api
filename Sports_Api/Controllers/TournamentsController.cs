using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sports_Api.Services;
//using Sports_Api.Models;
//using Sports_Api.Logic;


namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentsController : ControllerBase
    {
        private readonly ITournamentService _tournamentService;
        private readonly ILogger<TournamentsController> _logger;
        public TournamentsController(ITournamentService tournamentService, ILogger<TournamentsController> logger)
        {
            _tournamentService = tournamentService;
            _logger = logger;
        }
      
        [HttpGet]
        public IActionResult GetSingleTournament(int? tournamentId)
        {
            try
            {
                if (tournamentId.HasValue)
                {
                    var results = _tournamentService.GetSingleTournament(tournamentId).ToList();
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound("Record was not found");
                    }
                }
                else
                {
                    return BadRequest("There was an error while processing your request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error while processing your request {ex}");
            }
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            return Ok(_tournamentService.Get());
        }

        [Route("TournamentForSport")]
        public IActionResult GetTournaments(int? sportId, int? countryId)
        {
            try
            {
                if (sportId.HasValue && countryId.HasValue)
                {
                    var dbRecord = _tournamentService.GetTournamentsForSport(sportId, countryId).ToList();
                    if (dbRecord.ToList().Any())
                    {
                        _logger.LogInformation("Get request for tournaments successfull");
                        return Ok(dbRecord);
                    }
                    else
                    {
                        _logger.LogError("Get request for specific tournamants failed");
                        return NotFound("Record not found");
                    }
                }
                    return NotFound("Record not found");
            }
            catch (Exception ex)
            {
                _logger.LogError("Get request for specific tournaments failed", ex);
                return BadRequest("There was a problem findind the record please try again");
            }
        }

        [HttpPost]
        public  IActionResult Create ([FromBody]Tournament tournament)
        {
            try
            {
                    _logger.LogInformation($"{tournament} added to database");
                    _tournamentService.Add(tournament);
                    return Ok(tournament);
            }
            catch (Exception ex)
            {  
                    _logger.LogError($"Post Request failed for tornament", ex);
                return BadRequest($"Invalid tournament object submited {ex}");
            }
        }

        [HttpPut]
        public IActionResult Update(int ? tournamentId, [FromBody]Tournament tournament)
        {
            try
            {
                if (tournamentId !=tournament.TournamentId)
                {
                    return BadRequest("Unable to save changes please try again");
                }
                else
                {
                    _logger.LogInformation($"{tournament} record updated");
                    _tournamentService.Update(tournament);
                    return Ok("Record successfully updated" + tournament);
                }
               
            }
            catch (Exception ex)
            {
                _logger.LogError("Tournaments update requst failed", ex);
                return BadRequest("Record could not be updated");

            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult delete(int ?tournamentId)
        {
            try
            {
                var dbRecord = _tournamentService.Find(tournamentId);
                if (tournamentId.HasValue)
                {
                    if(dbRecord != null)
                    {
                        _logger.LogInformation($"Record {tournamentId} deleted");
                        _tournamentService.Delete(tournamentId);
                        return Ok("Record deleted");
                    }
                    else
                    {
                        return BadRequest("Record copuld not be deleted please try agin");
                    }
                }
                else
                {
                    return NotFound("Record not found");
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Api delete request failed", ex);
                return BadRequest("Record could not be deleted");
            }
        }

    }
}