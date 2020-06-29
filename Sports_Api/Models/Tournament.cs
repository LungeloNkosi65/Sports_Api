using System;
using System.Collections.Generic;

namespace Sports_Api
{
    public partial class Tournament
    {
        public Tournament()
        {
            Event = new HashSet<Event>();
            SportsTournament = new HashSet<SportsTournament>();
            TournamentBetType = new HashSet<TournamentBetType>();
        }

        public int TournamentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<SportsTournament> SportsTournament { get; set; }
        public virtual ICollection<TournamentBetType> TournamentBetType { get; set; }
    }
}
