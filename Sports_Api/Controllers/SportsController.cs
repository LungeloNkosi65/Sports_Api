using System;
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
        public SportsController(ISportService sportService,ILogger<SportsController> logger)
        {
            _sportService = sportService;
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<SportsTree> Get()
        {
            return _sportService.Get();
        }

        [HttpGet("{id}")]
        public IEnumerable<SportsTree> Get(int? id)
        {
            _logger.LogInformation("Sports Successfully retreived");
            return _sportService.Get(id);
        }

    }
}