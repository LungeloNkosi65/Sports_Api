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
    public class TournamentBetTypesController : ControllerBase
    {
        private readonly ITournamentBetTypeService _tournamentBetType;
        private readonly ILogger<TournamentBetTypesController> _logger;

        public TournamentBetTypesController(ITournamentBetTypeService tournamentBetType,ILogger<TournamentBetTypesController> logger)
        {
            _tournamentBetType = tournamentBetType;
            _logger = logger;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var results = _tournamentBetType.GetAllVm().ToList();
                if (results.Any())
                {
                    return Ok(results);
                }
                else
                {
                    return NotFound("No Records found ");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process your request {ex}");
            }
        }
        [HttpGet]
        public IActionResult Get(int? tbTid)
        {
            try
            {
                if (tbTid.HasValue)
                {
                    var results = _tournamentBetType.Get(tbTid).ToList();
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound("No records were found");
                    }
                }
                else
                {
                    return BadRequest("There was an error processing your request");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error procrssing your request {ex}");
            }
        }
        [HttpPost]
        public IActionResult Create(TournamentBetType tournamentBetType)
        {
            try
            {
                if (tournamentBetType != null)
                {
                    _logger.LogInformation("Record successfully created");
                    _tournamentBetType.Add(tournamentBetType);
                    return Ok("record successfully created");
                }
                else
                {
                    return BadRequest("There was an error processing request");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occured while trying to process post request ",ex);
                return BadRequest($"There was an error trying to process your request {ex}");
            }
        }

        [HttpDelete]
        public IActionResult Delete(int? tbTId)
        {
            try
            {
                if (tbTId.HasValue)
                {
                    _logger.LogInformation("Record with Id " + tbTId + "successfully deleted");
                    _tournamentBetType.Delete(tbTId);
                    return Ok("Record sucessfully deleted");
                }
                else
                {
                    return BadRequest("There was an error while processing your request");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("There was an error processing your request ", ex);
                return BadRequest($"There was an error processing your request {ex}");
            }
        }

        [HttpPut]
        public IActionResult Update(int? tbTId, TournamentBetType tournamentBetType)
        {
            try
            {
                if(tbTId.HasValue && tournamentBetType.TbTid == tbTId)
                {
                    _tournamentBetType.Update(tournamentBetType);
                    _logger.LogInformation("Recotrd updated");
                    return Ok("Record sucessfully updated");
                }
                else
                {
                    return BadRequest("There was an error processing your request");
                }

            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error processing your request {ex}");
            }
        }
    }
}