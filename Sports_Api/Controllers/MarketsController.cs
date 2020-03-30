using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Models;
using Sports_Api.Logic;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Market> Get(int ? betTypeId)
        {
            return AllLogic.GetMarketForBetType(betTypeId).ToArray();
        }
    }
}