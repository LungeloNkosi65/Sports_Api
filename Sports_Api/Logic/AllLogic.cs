using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sports_Api.Models;

namespace Sports_Api.Logic
{
    public class AllLogic
    {
        public static IEnumerable<Tournament> GetTournaments(int? sportId, int? countryId)
        {
            var sportTournament = Data.SportTournaments().Where(x => x.CountryId == countryId && x.SportId == sportId);
            var matchedTournament = from tournament in Data.Tournaments()
                                    where sportTournament.Any(x => x.TournamentId == tournament.TournamentId)
                                    select tournament;
            return matchedTournament;

        }
    }
}
