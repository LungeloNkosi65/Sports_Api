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
    public class BetTypeMarketsController : ControllerBase
    {
        private readonly IBetTypeMarketService _betTypeMarketService;
        private readonly ILogger<BetTypeMarketsController> _logger;

        public BetTypeMarketsController(IBetTypeMarketService betTypeMarketService, ILogger<BetTypeMarketsController> logger)
        {
            _logger = logger;
            _betTypeMarketService = betTypeMarketService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var results = _betTypeMarketService.GetAll().ToList();
                if (results.Any())
                {
                    return Ok(results);
                }
                else
                {
                    return NotFound("Records not found");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error while processing your request {ex}");
            }
        }

        [HttpGet]
        public IActionResult Get(int? betTypeMarketId)
        {
            try
            {
                if (betTypeMarketId.HasValue)
                {
                    var results = _betTypeMarketService.Get(betTypeMarketId).ToList();
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound("No Records were found");
                    }
                }
                else
                {
                    return BadRequest("There was an error while processing your request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error while processing your request {ex}");
            }
        }

        [HttpPost]
        public IActionResult Create(BetTypeMarket betTypeMarket)
        {
            try
            {
                if (betTypeMarket != null)
                {
                    _logger.LogInformation("Post Request: Successull");
                    _betTypeMarketService.Add(betTypeMarket);
                    return Ok("Record successfully added");
                }
                else
                {
                    return BadRequest("There was an error while processing your request");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Post Request: There was an error while processing your request", ex);
                return BadRequest($"There was an error while processing your request {ex}");
            }
        }

        [HttpPut]
        public IActionResult Update(BetTypeMarket betTypeMarket)
        {
            try
            {
                if (betTypeMarket != null)
                {
                    _logger.LogInformation("Put Request: Successfull");
                    _betTypeMarketService.Update(betTypeMarket);
                    return Ok("Record successfully updated");
                }
                else
                {
                    return BadRequest("There was an error while processing your request");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Put Request: There was an error while proccessing your request", ex);
                return BadRequest($"There was an error while processing your request {ex}");
            }
        }
        [HttpDelete]
        public IActionResult Delete(int? betTypeMarketId)
        {
            try
            {
                if (betTypeMarketId.HasValue)
                {
                    _betTypeMarketService.Delete(betTypeMarketId);
                    _logger.LogInformation("Delete Request: successfull");
                    return Ok("Record deleted");
                }
                else
                {
                    return BadRequest("There was an erro while processing request");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Delete Request: There was an error while proccessing request", ex);
                return BadRequest($"There was an error proccessing request {ex}");
            }
        }
    }
}