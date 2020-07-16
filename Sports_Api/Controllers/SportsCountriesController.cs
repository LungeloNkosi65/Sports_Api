using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsCountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly ISportCountryService _sportCountryService;
        private readonly ILogger<SportsCountriesController> _logger;

        public SportsCountriesController(ICountryService countryService, ILogger<SportsCountriesController> logger,ISportCountryService sportCountry)
        {
            _countryService = countryService;
            _logger = logger;
            _sportCountryService = sportCountry;
        }


        [HttpGet]
        [Route("GetZonke")]
        public IActionResult GetAllV()
        {
            try
            {
                var results = _sportCountryService.ViewGet().ToList();
                if (results.Any())
                {
                    return Ok(results);
                }
                else
                {
                    return NotFound("No Records found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error while processing your request {ex}");
            }
        }

        [HttpGet("{sportId}")]
        public IActionResult Get(int sportId)
        {
            try
            {
                if (sportId != null)
                {
                    var results = _countryService.CountryForSport(sportId).ToList();
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound("No records found");
                    }
                }
                else
                {
                    return BadRequest("There was an erro trying to process your request");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error trying to process your request {ex}");
            }

        }

        [HttpPost]
        public IActionResult AddSportInCountry(SportCountry sportCountry)
        {
            try
            {
                if(sportCountry != null)
                {
                    _sportCountryService.Add(sportCountry);
                    _logger.LogInformation("Post Api Call on SportCountry table successesfull");
                    return Ok("Record succesfullly added"+ sportCountry);
                }
                else
                {
                    _logger.LogError("Post call on SportCountry Table failed");
                    return BadRequest("There was an error trying to process your request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process your request {ex}");
                throw;
            }
        }
        
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetSportCountry()
        {
            try
            {
                var results = _sportCountryService.Get().ToList();
                if (results.Any())
                {
                    return Ok(results);
                }
                else
                {
                    return NotFound("No Records were found");
                }

            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process your request {ex}");
            }
        }


        [HttpDelete]
        public IActionResult RemoveSportFromCounrty(int? sportCountryId)
        {
            try
            {
                if (sportCountryId.HasValue)
                {
                    _sportCountryService.delete(sportCountryId);
                    _logger.LogInformation("Sport Removed from Country successfully");
                    return Ok("Record deleted");
                }
                else
                {
                    return BadRequest("There was an error while trying to process your request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process you request {ex}");

            }
        }

    }
}