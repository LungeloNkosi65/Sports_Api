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
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
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

        //[HttpGet("{sportId}")]
        //public IEnumerable<Country>GetSportCountry(int ? sportId)
        //{
        //    return _countryService.CountryForSport(sportId);
        //}
    }
}