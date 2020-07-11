using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsCountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public SportsCountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        [HttpGet("{sportId}")]
        public IEnumerable<Country> Get(int sportId)
        {

            return _countryService.CountryForSport(sportId);

        }

    }
}