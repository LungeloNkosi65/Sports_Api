using System;
using System.Collections.Generic;

namespace Sports_Api
{
    public partial class Event
    {
        public Event()
        {
            Odds = new HashSet<Odds>();
        }

        public int EventId { get; set; }
        public int TournamentId { get; set; }
        public string EventName { get; set; }
        public DateTime EeventDate { get; set; }

        public virtual Tournament Tournament { get; set; }
        public virtual ICollection<Odds> Odds { get; set; }
    }
}
