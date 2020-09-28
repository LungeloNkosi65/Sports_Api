using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sports_Api.Repository;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetTypesController : ControllerBase
    {
        private readonly IBetTypeService _betTypeService;
        private readonly ILogger<BetTypesController> _logger;
        public BetTypesController(IBetTypeService betTypeService, ILogger<BetTypesController> logger)
        {
            _logger = logger;
            _betTypeService = betTypeService;
        }
        [HttpGet]
        [Route("BetTypeForTournament")]
        public IActionResult Get(int? tournamentId)
        {
            //return _betTypeRepository.GetBetTypesForTournament(tournamentId);
            try
            {
                if (tournamentId.HasValue)
                {
                    var result = _betTypeService.GetBetTypesForTournament(tournamentId).ToList();
                    if (result.Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound($"No record was found for the id :{tournamentId}");
                    }
                }
                else
                {
                    return BadRequest("Invalid Id submited, No record was found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process the request {ex}");
            }

        }

        [HttpGet]
        
        public IActionResult GetSingle(int? betTypeId)
        {
            try
            {
                if (betTypeId.HasValue)
                {
                    var results = _betTypeService.GetSingle(betTypeId).ToList();
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound("Record not found");
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
            var results = _betTypeService.Get().ToList();
            return Ok(results);
        }
        [HttpPost]
        public IActionResult Create(BetType betType)
        {
            try
            {
                if (betType == null)
                {
                    return BadRequest(" POST: There was an errpr trying to process the request");
                }
                else
                {
                    _betTypeService.Add(betType);
                    _logger.LogInformation($"Record successfuly created ");
                    return Ok("Record successfully added");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process the request {ex}");
               
            }
        }

        [HttpDelete]
        public IActionResult Delete(int? betTypeId)
        {
            try
            {
                if (betTypeId.HasValue)
                {
                    var dbRecord = _betTypeService.Find(betTypeId);
                    if (dbRecord == null)
                    {
                        _logger.LogError("Delete operation failed");
                        return NotFound("Record was not found on the database");
                    }
                    else{
                        _betTypeService.Delete(betTypeId);
                        _logger.LogInformation($"Record with id: {betTypeId} deleted");
                        return Ok("Record successfully deleted");
                    }
                }
                else
                {
                    _logger.LogError("Delete operation failed");
                    return BadRequest("There was an error trying to process the request please try again");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process the request {ex}");
            }
        }

        [HttpPut]
        public IActionResult Update(int? betTypeId, [FromBody] BetType betType)
        {
            try
            {
                if(betTypeId.HasValue && betType != null)
                {
                    if (betTypeId == betType.BetTypeId)
                    {
                        _betTypeService.Update(betType);
                        _logger.LogInformation($"Record with id: {betTypeId} deleted from BetType Table");
                        return Ok("Record deleted successfully");
                    }
                    else
                    {
                        //_logger.LogError("Delet: Operation failed");
                        return NotFound("There was an error trying to process the request . Record was not found");
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