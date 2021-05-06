using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class Odds
    {
        [Key]

        public int OddId { get; set; }
        public int BetTypeMarketId { get; set; }
        public int EventId { get; set; }
        public decimal Odds1 { get; set; }

        public virtual BetTypeMarket BetTypeMarket { get; set; }
        public virtual Event Event { get; set; }
    }
}
