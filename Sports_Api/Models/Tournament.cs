using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class Tournament
    {
        public Tournament()
        {
            BetTbl = new HashSet<BetTbl>();
            Event = new HashSet<Event>();
            SportsTournament = new HashSet<SportsTournament>();
            TournamentBetType = new HashSet<TournamentBetType>();
        }
        [Key]

        public int TournamentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BetTbl> BetTbl { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<SportsTournament> SportsTournament { get; set; }
        public virtual ICollection<TournamentBetType> TournamentBetType { get; set; }
    }
}
