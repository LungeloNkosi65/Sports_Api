using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class Market
    {
        public Market()
        {
            BetTbl = new HashSet<BetTbl>();
            BetTypeMarket = new HashSet<BetTypeMarket>();
        }
        [Key]

        public int MarketId { get; set; }
        public string MarketName { get; set; }

        public virtual ICollection<BetTbl> BetTbl { get; set; }
        public virtual ICollection<BetTypeMarket> BetTypeMarket { get; set; }
    }
}
