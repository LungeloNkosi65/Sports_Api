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
    public class TournamentsController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<Tournament> Get(int? sportId,int ? countryId)
        {
            //var a= "https://localhost:44365/api/tournaments?sportId=5&countryId=1";
            return AllLogic.GetTournaments(sportId,countryId).ToArray();
        }
    }
}