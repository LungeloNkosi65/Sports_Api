using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CustomModel
{
    public class OddsViewModel
    {
        [Key]
        public int OddId { get; set; }
        public int BetTypeMarketId { get; set; }
        public string Bet_Market_Code { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public decimal Odds { get; set; }
    }
}
