using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sports_Api.Services.Interfaces;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BonusTblsController : ControllerBase
    {
        private readonly ILogger<BonusTblsController> _logger;
        private readonly IBonusTblService _bonusTblService;

        public BonusTblsController(IBonusTblService bonusTblService, ILogger<BonusTblsController> logger)
        {
            _logger = logger;
            _bonusTblService = bonusTblService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var results = _bonusTblService.GetAll().ToList();
                if (results.Any())
                {
                    return Ok(results);
                }
                else
                {
                    return NotFound($" Sorry no records found");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error while processing your request {ex}");
            }
        }

        [HttpGet]
        [Route("GetSingle")]
        public IActionResult GetSingle(int? bonusId)
        {
            try
            {
                if (bonusId.HasValue)
                {
                    var results = _bonusTblService.GetSingle(bonusId).ToList();
                    if (results.Any())
                    {
                        return Ok(results);
                    }
                    else
                    {
                        return NotFound("Sorry no record was found ");
                    }
                }
                else
                {
                    return BadRequest($"There was an error while processing your request");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"There was an error while proccessing your request {ex}");
            }
        }


        [HttpPost]
        public IActionResult Create([FromBody]BonusTbl bonusTbl)
        {
            try
            {
                if (bonusTbl != null)
                {
                    _bonusTblService.Add(bonusTbl);
                    _logger.LogInformation($"Record on BonusTbl successfully added");

                    return Ok("Record successfully added");
                }
                else
                {
                    return BadRequest($"There was an error while processing your request ");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("An error eoccured", ex);
                return BadRequest($"There was an error while processing request {ex}");
            }
        }


        [HttpDelete]
        public IActionResult Delete(int? bonusId)
        {
            try
            {
                if (bonusId.HasValue && bonusId!=null)
                {
                    _bonusTblService.delete(bonusId);
                    _logger.LogInformation($"Record with id: {bonusId} successfully deleted");
                    return Ok("Record Successfully deleted");
                }
                else
                {
                    return BadRequest($"There was an error while processing your request");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"There was an error while processing your request {ex}");
            }
        }


        [HttpPut]
        public IActionResult Update(int? bonusId,BonusTbl bonusTbl)
        {
            try
            {
                if(bonusId.HasValue && bonusTbl != null)
                {
                    if (bonusTbl.BonusId == bonusId)
                    {
                        _bonusTblService.update(bonusTbl);
                        _logger.LogInformation($"Recotrd with id : {bonusId} successfully updated");
                        return Ok("Record sucessfully updated");
                    }
                    else
                    {
                        return NotFound("Sorry no matching record was found");
                    }
                }
                else
                {
                    return BadRequest("There was an error while processing your request");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occured while proccessing request ", ex);
                return BadRequest($"There was an error while proccessing your request {ex}");
            }
        }

    }
}
