using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class TournamentBetType
    {
        [Key]

        public int TbTid { get; set; }
        public int TournamentId { get; set; }
        public int BetTypeId { get; set; }

        public virtual BetType BetType { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
