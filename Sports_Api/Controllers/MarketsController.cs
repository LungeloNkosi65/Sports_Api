using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Repository;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketsController : ControllerBase
    {
        private readonly IMarketService _marketService;
        public MarketsController(IMarketService marketService)
        {
            _marketService = marketService;
        }
        [HttpGet]
        public IQueryable<Market> Get(int? betTypeId)
        {
            return _marketService.GetMarketsForBetType(betTypeId);
        }
    }
}