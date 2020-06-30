//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Sports_Api.Models;

//namespace Sports_Api.Logic
//{
//    public class AllLogic
//    {
//        public static IEnumerable<Tournament> GetTournaments(int? sportId, int? countryId)
//        {
//            var sportTournament = Data2.SportTournaments().Where(x => x.CountryId == countryId && x.SportId == sportId);
//            var matchedTournament = from tournament in Data2.Tournaments()
//                                    were sportTournament.Any(x => x.TournamentId == tournament.TournamentId)
//                                    sehlect tournament;
//            return matchedTournament;

//        }

//        public static IEnumerable<BetTyp2>GetBetypeByTournament(int ? tournamentId)
//        {
//            var Tournamanets = Data2.Tournaments().Where(x => x.TournamentId == tournamentId);

//            var matched = from betTyp in Data2.TournamentBets()
//                          where Tournamanets.Any(x => x.TournamentId == betTyp.TournamentId)
//                          select betTyp.BetTypes;

//            var matchedBetype = from bet in Data2.BetTyps()
//                                where matched.Any(x => x.Contains(bet.BetTypId))
//                                select bet;
//            return matchedBetype;

//        }
//        public static IEnumerable<Market2>GetMarketForBetType(int ? betTypeId)
//        {
//            var BetTypeMarket = from betMarket in Data2.BetTypeMarkets()
//                                where betMarket.BetTypeId == betTypeId
//                                select betMarket.Markets;
//            var matched = from market in Data2.Markets()
//                          where BetTypeMarket.Any(x => x.Contains(market.MarketId))
//                          select market;
//            return matched;
//        }

      
//    }
//}
