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
    public class OddsDefaultController : ControllerBase
    {
        private readonly IOddsDefaultService _oddsDefaultService;
        private readonly ILogger<OddsDefaultController> _loggeer;

        public OddsDefaultController(IOddsDefaultService oddsDefaultService,ILogger<OddsDefaultController> logger)
        {
            _oddsDefaultService = oddsDefaultService;
            _loggeer = logger;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetALl()
        {
            try
            {
                var results = _oddsDefaultService.GetAll().ToList();
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

                return BadRequest($"There was an error trying to process your request {ex}");
            }
        }

        [HttpGet]
        public IActionResult Get(int? oddId)
        {
            try
            {
                if (oddId.HasValue)
                {
                    var results = _oddsDefaultService.GetSingleOdd(oddId).ToList();
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound("There was no record found");
                    }
                }
                else
                {
                    return BadRequest("There was an error whle trying to process your request");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error trying to process your request {ex}");
            }
        }

        [HttpPost]
        public IActionResult Create(Odds odds)
        {
            try
            {
                if (odds != null)
                {
                    _loggeer.LogInformation("Post call successfull on Odds table");
                    _oddsDefaultService.Add(odds);
                    return Ok("Record successfully created");
                }
                else
                {
                    return BadRequest("There was an error while trying to process your request");
                }
            }
            catch (Exception ex)
            {
                _loggeer.LogError("Post call: There was an error while trying to process request", ex);
                return BadRequest($"There was an error while trying to process your request {ex}");
            }
        }

        [HttpPut]
        public IActionResult Update(Odds odds)
        {
            try
            {
                if (odds != null)
                {
                    _loggeer.LogInformation("Update Request: successfull");
                    _oddsDefaultService.Update(odds);
                    return Ok("Record successfully updated");
                }
                else
                {
                    return BadRequest("There was an error while processing your request");
                }
            }
            catch (Exception ex)
            {
                _loggeer.LogError("Update Request: Therfe was an error while trying to process request ",ex);
                return BadRequest($"There was an error while processing request {ex}");
            }
        }

        public IActionResult Delete(int? oddId)
        {
            try
            {
                if (oddId.HasValue)
                {
                    _loggeer.LogInformation("Delete Request: succsessful");
                    _oddsDefaultService.Delete(oddId);
                    return Ok("Record Successfully deleted");
                }
                else
                {
                    return BadRequest("There was an error while processing  request");
                }
            }
            catch (Exception ex)
            {
                _loggeer.LogError("Delete Request: There was an erro while processing request", ex);
                    return BadRequest($"There was an error while processing your request {ex}");

            }
        }
    }
}