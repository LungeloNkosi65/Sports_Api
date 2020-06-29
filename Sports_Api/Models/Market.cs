using System;
using System.Collections.Generic;

namespace Sports_Api
{
    public partial class Market
    {
        public Market()
        {
            BetTypeMarket = new HashSet<BetTypeMarket>();
        }

        public int MarketId { get; set; }
        public string MarketName { get; set; }

        public virtual ICollection<BetTypeMarket> BetTypeMarket { get; set; }
    }
}
