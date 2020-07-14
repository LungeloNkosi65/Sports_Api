using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api
{
    public class CustomOdds
    {
        [Key]
        public int OddId { get; set; }
        public int EventId { get; set; }
        public int BetTypeId { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public decimal Odds { get; set; }

    }
}