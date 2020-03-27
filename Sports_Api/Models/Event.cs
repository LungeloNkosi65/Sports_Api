using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public int TournamentId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }

        public Event(int eventId,int tournametId, string eventName, DateTime eventDate)
        {
            EventId = eventId;
            TournamentId = tournametId;
            EventName = eventName;
            EventDate = eventDate;
        }
    }
}
