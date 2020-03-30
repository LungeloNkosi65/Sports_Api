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

        public static IEnumerable<BetTyp>GetBetypeByTournament(int ? tournamentId)
        {
            var Tournamanets = Data.Tournaments().Where(x => x.TournamentId == tournamentId);

            var matched = from betTyp in Data.TournamentBets()
                          where Tournamanets.Any(x => x.TournamentId == betTyp.TournamentId)
                          select betTyp.BetTypes;

            var matchedBetype = from bet in Data.BetTyps()
                                where matched.Any(x => x.Contains(bet.BetTypId))
                                select bet;
            return matchedBetype;

        }
        public static IEnumerable<Market>GetMarketForBetType(int ? betTypeId)
        {
            var BetTypeMarket = from betMarket in Data.BetTypeMarkets()
                                where betMarket.BetTypeId == betTypeId
                                select betMarket.Markets;
            var matched = from market in Data.Markets()
                          where BetTypeMarket.Any(x => x.Contains(market.MarketId))
                          select market;
            return matched;
        }

      
    }
}
