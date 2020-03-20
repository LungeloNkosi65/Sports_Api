using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Models;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsCountriesController : ControllerBase
    {
        public IEnumerable<Country> Get(int id)
        {
            if (id == null)
            {
                return Data.GetCountries(id);
            }
            else
            {
                return Data.Countries();
            }
        }

    }
}