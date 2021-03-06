﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class SportsController : ControllerBase
    {

        private readonly ISportService _sportService;
        private readonly ILogger<SportsController> _logger;
        public SportsController(ISportService sportService, ILogger<SportsController> logger)
        {
            _sportService = sportService;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = _sportService.Get();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetSingle")]
        public IActionResult Get(int? sportId)
        {
            try
            {
                if (sportId.HasValue)
                {
                    var result = _sportService.Get(sportId);
                    if (result.Any())
                    {
                        _logger.LogInformation("Sports Successfully retreived");
                        return Ok(result);
                    }
                    else
                    {
                        _logger.LogError($"Get request for sport unsuccessfull record not found on the Db");
                        return NotFound("Record not found");
                    }
                }
                else
                {
                    return BadRequest("Invalid id passed request failed");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error while processing your request {ex}");
            }
        }
        [HttpPost]
        public IActionResult Create(SportsTree sportsTree)
        {
            try
            {
                if (sportsTree == null)
                {
                    _logger.LogError("Create request failed invalid data submited");
                    return BadRequest("Invalid object submited");
                }
                else
                {
                    _logger.LogInformation("Record successfully added");
                    _sportService.Add(sportsTree);
                    return Ok("Record successfully added");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Create operation failed", ex);
                return BadRequest($"There was an error while processing your request {ex}");
            }
        }

        [HttpDelete]
        public IActionResult Delete(int? sportId)
        {
            try
            {
                if (sportId.HasValue)
                {
                    var dbRecord = _sportService.Find(sportId);
                    if (dbRecord == null)
                    {
                        _logger.LogError("delet" +
                            "e operation failed");
                        return BadRequest("Record not found");
                    }
                    else
                    {
                        _logger.LogInformation("Record successfully deleted ", dbRecord);
                        _sportService.delete(sportId);
                        return Ok("Record successfully deleted");
                    }
                }
                else
                {
                    return BadRequest("Invalid Id submited, request failed");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occured ", ex);
                return BadRequest($"There was an error while processing your request {ex}");
            }
        }
        [HttpPut]
        public IActionResult Update(int? sportId, SportsTree sportsTree)
        {
            try
            {
                if (sportId == sportsTree.SportId)
                {
                    _logger.LogInformation($"Record with id:{sportId} updated");
                    _sportService.update(sportsTree);
                    return Ok("Record successfully updated");
                }
                else
                {
                    _logger.LogError($"Update operation failed for record with id:{sportId}");
                    return BadRequest("Record not found");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Update operation failed ", ex);
                return BadRequest($"There was an error while processing your request {ex}");
            }
        }

    }
}