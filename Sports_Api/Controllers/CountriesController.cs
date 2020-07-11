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
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly ILogger<CountriesController> _logger;

        public CountriesController(ICountryService countryService, ILogger<CountriesController> logger)
        {
            _countryService = countryService;
            _logger = logger;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            var results=_countryService.Get();
            return Ok(results);
        }
        [HttpGet("{countryId}")]
        public IActionResult Get(int? countryId)
        {
            //return _countryService.Get(countryId);
            try
            {
                if (countryId.HasValue)
                {
                    var results=_countryService.Get(countryId);
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound("No countries found");
                    }
                }
                else
                {
                    return BadRequest("Invalid Id, no country found");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error trying to process the request {ex}");
            }
        }

        [Route("GetSportCountry")]
        public IActionResult GetSportCountry(int? sportId)
        {
            //_logger.LogInformation($"{sportId} reqiested countries the sport is offerd in");
            try
            {
                if (sportId.HasValue)
                {
                    var results = _countryService.CountryForSport(sportId);
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound($"No countries foound for id: {sportId}");
                    }
                }
                else
                {
                    return BadRequest("Invalid id please submit valid id");
                }
            }
            catch (Exception ex)
            {

                return BadRequest("There was an erro trying to get the data "+ ex);
            }
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            try
            {
                if (country == null)
                {
                    _logger.LogError("Create operation failed on Countries table");
                    return BadRequest("Invalid data submited");
                }
                else
                {
                    _logger.LogInformation("Create request successfull on Countries table");
                    _countryService.Add(country);
                    return Ok($"Record successfully added {country}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Create operation failed on Countries table", ex);
                return BadRequest($"There was an error trying nto process the request {ex}");
            }
        }

        [HttpDelete]
        public IActionResult Delete(int? countryId)
        {
            try
            {
                if (countryId.HasValue)
                {
                    _countryService.Delete(countryId);
                    _logger.LogInformation("Record with id: {countryId} deleted");
                    return Ok("Record successfully deleted");
                }
                else
                {
                    _logger.LogError("Delete opration falied on Countries table");
                    return BadRequest("Record could not be deleted");
                }

            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process the request {ex}");
            }
        }

        [HttpPut]
        public IActionResult Update(int? countryId,Country country)
        {
            try
            {
                if(countryId.HasValue && country != null)
                {
                    if (countryId == country.CountryId)
                    {
                        _logger.LogInformation("Record on Countries table updated");
                        _countryService.Update(country);
                        return Ok("Record successfully updated");
                    }
                    else
                    {
                        return BadRequest("There was a problem trying to update the record");
                    }
                }
                else
                {
                    return BadRequest("There was an error trying to update reord");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error trying to process the request {ex}");
            }
        }
    }
}