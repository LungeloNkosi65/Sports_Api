using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class SportsController : ControllerBase
    {

        private readonly ISportService _sportService;
        public SportsController(ISportService sportService)
        {
            _sportService = sportService;
        }
        [HttpGet]
        public IEnumerable<SportsTree> Get()
        {
            return _sportService.Get();
        }

        [HttpGet("{id}")]
        public IEnumerable<SportsTree>Get(int? id)
        {
            return _sportService.Get(id);
        }

    }
}