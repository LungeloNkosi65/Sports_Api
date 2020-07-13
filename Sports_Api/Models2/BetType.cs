using System;
using System.Collections.Generic;

namespace Sports_Api
{
    public partial class BetType
    {
        public BetType()
        {
            BetTypeMarket = new HashSet<BetTypeMarket>();
            TournamentBetType = new HashSet<TournamentBetType>();
        }

        public int BetTypeId { get; set; }
        public string BetTypeName { get; set; }

        public virtual ICollection<BetTypeMarket> BetTypeMarket { get; set; }
        public virtual ICollection<TournamentBetType> TournamentBetType { get; set; }
    }
}
