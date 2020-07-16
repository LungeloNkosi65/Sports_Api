using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sports_Api.Repository;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketsController : ControllerBase
    {
        private readonly IMarketService _marketService;
        ILogger<MarketsController> _logger;
        public MarketsController(IMarketService marketService, ILogger<MarketsController> logger)
        {
            _marketService = marketService;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get(int? betTypeId)
        {
            //return _marketService.GetMarketsForBetType(betTypeId);
            try
            {
                if (betTypeId.HasValue)
                {
                    var results = _marketService.GetMarketsForBetType(betTypeId).ToList();
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound($"Records with id: {betTypeId} were not found");
                    }
                }
                else
                {
                    return BadRequest($"There was an error trying to process the request");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error trying to process the request {ex}");
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var results = _marketService.Get().ToList();
                if (results.Any())
                {
                    return Ok(results);
                }
                else
                {
                    return NotFound("No records found");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"Therw was an error while processing your request {ex}");
            }
        }

        [HttpGet]
        [Route("GetSingle")]
        public IActionResult GetSingle(int? marketId)
        {
            try
            {
                if(marketId.HasValue)
                {
                    var results = _marketService.GetSingle(marketId).ToList();
                    return Ok(results);
                }
                else
                {
                    return BadRequest("There was an error while proccessing request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error while proce=cessing request");
            }
        }
        [HttpPost]
        public IActionResult Create (Market market)
        {
            try
            {
                if (market != null)
                {
                    _logger.LogInformation("Post Request: successfull");
                    _marketService.Add(market);
                    return Ok("Rcord sucessfully addeed");
                }
                else
                {
                    return BadRequest("There was an error while processing your request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error while proccessing your request {ex}");
            }
        }

        [HttpDelete]
        public IActionResult Delete(int? marketId)
        {
            try
            {
                if (marketId.HasValue)
                {
                    _logger.LogInformation("Delete Requestr: Successfull");
                    _marketService.delete(marketId);
                    return Ok("Record successfullyt deleted");
                }
                else
                {
                    return BadRequest("Therw was an error while processing request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error while processing request {ex}");
            }
        }

        [HttpPut]
        public IActionResult Update(int? marketId, Market market)
        {
            try
            {
                if(marketId.HasValue && marketId == market.MarketId)
                {
                    _logger.LogInformation("Put Request: Successfull");
                    _marketService.update(market);
                    return Ok("Record sucessfully uypdated");
                }
                else
                {
                    return BadRequest("There was an error while proccessing request");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Put Request: Failed, there was an error while proccessing request");
                return BadRequest($"There was an error while proccessing request {ex}");
            }
        }
    }
}