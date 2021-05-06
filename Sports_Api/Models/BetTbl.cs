using Sports_Api;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class BetTbl
    {
        [Key]
        public int BetId { get; set; }
        public int BetSlipId { get; set; }
        public int SportId { get; set; }

        public int TournamentId { get; set; }
        public int EventId { get; set; }
        public int BetTypeId { get; set; }
        public int MarketId { get; set; }
        public string TicketNumber { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public virtual BetSlip BetSlip { get; set; }
        public virtual BetType BetType { get; set; }
        public virtual Event Event { get; set; }
        public virtual Market Markert { get; set; }
        public virtual SportsTree Sport { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
