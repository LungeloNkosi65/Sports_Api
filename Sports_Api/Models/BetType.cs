using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class BetType
    {
        public BetType()
        {
            BetTbl = new HashSet<BetTbl>();
            BetTypeMarket = new HashSet<BetTypeMarket>();
            TournamentBetType = new HashSet<TournamentBetType>();
        }

        [Key]
        public int BetTypeId { get; set; }
        public string BetTypeName { get; set; }

        public virtual ICollection<BetTbl> BetTbl { get; set; }
        public virtual ICollection<BetTypeMarket> BetTypeMarket { get; set; }
        public virtual ICollection<TournamentBetType> TournamentBetType { get; set; }
    }
}
