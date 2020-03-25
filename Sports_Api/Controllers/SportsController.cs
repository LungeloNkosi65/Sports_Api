using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Models;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class SportsController : ControllerBase
    {

        
        [HttpGet]
        public IEnumerable<SportsTree> Get()
        {
            return Data.Sports().ToArray();
        }
       
    }
}