using System;
using System.Collections.Generic;

namespace Sports_Api
{
    public partial class SportsTournament
    {
        public int SportTourtnamentId { get; set; }
        public int SportId { get; set; }
        public int CountryId { get; set; }
        public int TournamentId { get; set; }

        public virtual Country Country { get; set; }
        public virtual SportsTree Sport { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
