using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class Event
    {
        public Event()
        {
            BetTbl = new HashSet<BetTbl>();
            Odds = new HashSet<Odds>();
        }
        [Key]

        public int EventId { get; set; }
        public int TournamentId { get; set; }
        public string EventName { get; set; }
        public DateTime EeventDate { get; set; }

        public virtual Tournament Tournament { get; set; }
        public virtual ICollection<BetTbl> BetTbl { get; set; }
        public virtual ICollection<Odds> Odds { get; set; }
    }
}
