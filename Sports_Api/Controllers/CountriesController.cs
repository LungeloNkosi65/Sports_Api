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
        public IEnumerable<Country> Get()
        {
            return _countryService.Get();
        }
        [HttpGet("{countryId}")]
        public IEnumerable<Country> Get(int? countryId)
        {
            return _countryService.Get(countryId);
        }

        [Route("GetSportCountry")]
        public IEnumerable<Country> GetSportCountry(int sportId)
        {
            _logger.LogInformation($"{sportId} reqiested countries the sport is offerd in");
            return _countryService.CountryForSport(sportId);
        }
    }
}