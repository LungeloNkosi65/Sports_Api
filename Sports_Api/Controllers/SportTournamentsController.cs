using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportTournamentsController : ControllerBase
    {
        private readonly ISportTournamentService _sportTournamentService;
        private readonly ILogger<SportTournamentsController> _logger;

        public SportTournamentsController(ISportTournamentService sportTournamentService,ILogger<SportTournamentsController> logger)
        {
            _sportTournamentService = sportTournamentService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(int? sportTournamentId)
        {
            try
            {
                var result = _sportTournamentService.getSingleSportTournament(sportTournamentId).ToList();
                if (result.Any())
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound("Record not found");
                }
            }
            catch (Exception ex)
            {

                return BadRequest("There was an error trying to process your request " + ex);
            }
        }
        [HttpPost]
        public IActionResult CreateLink(SportsTournament sportsTournament)
        {
            try
            {
                if (sportsTournament != null)
                {
                    _logger.LogInformation("Record successfully added");
                    _sportTournamentService.Add(sportsTournament);
                    return Ok("Record successfully added");
                }
                else
                {
                    return BadRequest("There was an error trying to process your request");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Link Operation failed ", ex);
                return BadRequest($"There was an error trying to process your request {ex}");

            }
        }

        [HttpDelete]
        public IActionResult Delete(int? sportTournamentId)
        {
            try
            {
                if (sportTournamentId.HasValue)
                {
                    _logger.LogInformation("Record successfully deleted");
                    _sportTournamentService.Delete(sportTournamentId);
                    return Ok("Record successfully deleted");
                }
                else
                {
                   return NotFound("Ther was an error processing your request");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Delete operation failed ", ex);
                return BadRequest($"There was an error processing your request {ex}");
            }
        }
        [HttpPut]
        public IActionResult Update(int? sportTournamentId, SportsTournament sportsTournament)
        {
            try
            {
                if (sportTournamentId.HasValue && sportTournamentId==sportsTournament.SportTourtnamentId)
                {
                    _logger.LogInformation("Record successfully updated");
                    _sportTournamentService.Update(sportsTournament);
                    return Ok("Record successfully updated");
                }
                else
                {
                    return NotFound("Record was not found");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Update operation failed ", ex);
                return BadRequest($"There was an error processing your request {ex}");
            }
        }
    }
}