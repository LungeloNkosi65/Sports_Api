//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Sports_Api.Models;
//using Sports_Api.Repository;

//namespace Sports_Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ExoticsController : ControllerBase
//    {
//         static readonly IExotic repository = new ExoticsRepository();
//        public IEnumerable<Exotics2> GetAllExotics()
//        {
//            return repository.GetAll();
//        }
        
//        public Exotics2 AddExotic(Exotics2 exotics)
//        {
//            repository.Add(exotics);
//            return exotics;
//        }
//    }
//}