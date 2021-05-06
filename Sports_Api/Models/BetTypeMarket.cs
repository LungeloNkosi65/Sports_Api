using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class BetTypeMarket
    {
        public BetTypeMarket()
        {
            Odds = new HashSet<Odds>();
        }
        [Key]

        public int BetTypeMarketId { get; set; }
        public int BetTypeId { get; set; }
        public int MarketId { get; set; }

        public virtual BetType BetType { get; set; }
        public virtual Market Market { get; set; }
        public virtual ICollection<Odds> Odds { get; set; }
    }
}
