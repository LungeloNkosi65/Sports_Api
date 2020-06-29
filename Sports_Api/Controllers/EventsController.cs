//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Sports_Api.Models;

//namespace Sports_Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EventsController : ControllerBase
//    {
//        [HttpGet]
//        public IEnumerable<Event2>Get(int ? tournamentId)
//        {
//            return Data2.EventsByToournament(tournamentId).ToArray();
//        }
//    }
//}