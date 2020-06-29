using System;
using System.Collections.Generic;

namespace Sports_Api
{
    public partial class BetTypeMarket
    {
        public int BetTypeMarketId { get; set; }
        public int BetTypeId { get; set; }
        public int MarketId { get; set; }

        public virtual BetType BetType { get; set; }
        public virtual Market Market { get; set; }
    }
}
