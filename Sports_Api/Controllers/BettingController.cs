using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sports_Api.Models.CustomModel;
using Sports_Api.Services;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BettingController : ControllerBase
    {
        private readonly IBetService _betService;
        private readonly ILogger<BettingController> _logger;

        public BettingController(IBetService betService,ILogger<BettingController> logger)
        {
            _betService = betService;
            _logger = logger;
        }
        [HttpGet]
        [Route("GetBetEvents")]
        public IActionResult GetBetEvents()
        {
            try
            {
                var results = _betService.GetBetEvents().ToList();
                if (results.Any())
                {
                    return Ok(results);
                }
                else
                {

                    return NotFound("There were no records found");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error processing your request {ex}");
            }
        }

        [HttpGet]
        [Route("GetBets")]
        public IActionResult GetBets()
        {
            try
            {
                var results = _betService.GetBets().ToList();
                if (results.Any())
                {
                    return Ok(results);
                }
                else
                {

                    return NotFound("There were no records found");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error processing your request {ex}");
            }
        }

        [HttpGet]
        [Route("RecentBets")]
        public IActionResult GetRecentBets(string accountNumber)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(accountNumber))
                {
                    var result = _betService.RecentBets(accountNumber).ToList();
                    if (result.Any())
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound("No Recent Bets fount for " + accountNumber);
                    }
                }
                else
                {
                    return BadRequest("Null parameter passed");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error trying to process request {ex}");
            }
        }

        [HttpPut]
        public IActionResult CancellBet(int? betId)
        {
            try
            {
                if (betId.HasValue)
                {
                    _betService.CancellBet(betId);
                    _logger.LogInformation($"Api request for bet {betId} cancelled");
                    return Ok("Bet successfully cancelled");
                }
                else
                {
                    _logger.LogError($"Cancell request for bet failed");
                    return BadRequest("Null parameter passed");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error trying to process your request {ex}");
            }
        }

        [HttpPost]
        public IActionResult PlaceBet([FromBody] SubmitedBet submitedBet)
        {
            try
            {
                if (submitedBet != null)
                {
                    _betService.PlaceBet(submitedBet);
                    return Ok("Bet successfully struck");
                }
                else
                {
                    return BadRequest("Sorry something wen wtong");
                }
            }
            catch (Exception ex)
            {

                return BadRequest("There was an error trying to process your request " + ex);
            }
        }

        
    }
}