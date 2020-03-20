using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Models;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {
        public static List<SportsTree> SportsList = Sports();
        public static List<SportsTree> Sports()
        {
            SportsList = new List<SportsTree>()
            {
                  new SportsTree(1, "Betgames Africa", "https://new.hollywoodbets.net/assets/images/icons/Betgames.svg"),
                new SportsTree(2, "Live In-Play", "https://new.hollywoodbets.net/assets/images/icons/live-in-play.svg"),
                new SportsTree(3, "Sport Exotics", "https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportsTree(4, "Horse Racing", "https://new.hollywoodbets.net/assets/images/icons/horse-racing.svg"),
                new SportsTree(5, "Soccer", "https://new.hollywoodbets.net/assets/images/icons/soccer.svg"),
                new SportsTree(6, "Lucky Numbers", "https://new.hollywoodbets.net/assets/images/icons/lucky-numbers.svg"),
                new SportsTree(7, "Rugby", "https://new.hollywoodbets.net/assets/images/icons/rugby.svg"),
                new SportsTree(8, "Cricket", "https://new.hollywoodbets.net/assets/images/icons/cricket.svg"),
                new SportsTree(9, "Golf", "https://new.hollywoodbets.net/assets/images/icons/golf.svg"),
                new SportsTree(10, "Aussie Rules", "https://new.hollywoodbets.net/assets/images/icons/aussie-rules.svg"),
                new SportsTree(11, "Bandy", "https://new.hollywoodbets.net/assets/images/icons/bandy.svg"),
                new SportsTree(12, "BasketBall", "https://new.hollywoodbets.net/assets/images/icons/basketball.svg"),
                new SportsTree(13, "Bowls", "https://new.hollywoodbets.net/assets/images/icons/bowls.svg"),
                new SportsTree(14, "Boxing", "https://new.hollywoodbets.net/assets/images/icons/boxing.svg"),
                new SportsTree(15, "Darts", "https://new.hollywoodbets.net/assets/images/icons/darts.svg"),
                new SportsTree(16, "Futsal", "https://new.hollywoodbets.net/assets/images/icons/futsal.svg"),
                new SportsTree(17, "Ice Hockey", "https://new.hollywoodbets.net/assets/images/icons/ice-hockey.svg"),
                new SportsTree(18, "MMA", "https://new.hollywoodbets.net/assets/images/icons/mma.svg"),
                new SportsTree(19, "Motorsport", "https://new.hollywoodbets.net/assets/images/icons/motorsport.svg"),
                new SportsTree(20, "Table Tennis", "https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportsTree(21, "Vollyball", "https://new.hollywoodbets.net/assets/images/icons/volleyball.svg")
            };
            return SportsList;
        }
        [HttpGet]
        public IEnumerable<SportsTree> Get()
        {
            return Sports().ToArray();
        }
       
    }
}