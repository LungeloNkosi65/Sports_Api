using System;
using System.Collections.Generic;
using System.Linq;

namespace Sports_Api.Models
{
    public class Data
    {
        public static List<Country> CountrList = Countries();
        public static List<SportsCountry> SportsCountList = SportsCountries();
        public static List<Tournament> TournamentsList = Tournaments();
        public static List<SportTournament> SportTournamentsList = SportTournaments();
        public static List<Event> EventsList = Events();

        public static List<SportsTree> SportsList = Sports();
        public static List<SportsTree> Sports()
        {
            SportsList = new List<SportsTree>()
            {
                new SportsTree(1, "Betgames Africa", "https://new.hollywoodbets.net/assets/images/icons/Betgames.svg"),
                new SportsTree(2, "Live In-Play", "https://new.hollywoodbets.net/assets/images/icons/live-in-play.svg"),
                new SportsTree(3, "Sport Exotics", "https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportsTree(4, "Horse Racing", "https://new.hollywoodbets.net/assets/images/icons/horse-racing.svg"),
                new SportsTree(5, "Soccer", "https://new.hollywoodbets.net/assets/images/icons/soccer.svg"),
                new SportsTree(6, "Lucky Numbers", "https://new.hollywoodbets.net/assets/images/icons/lucky-numbers.svg"),
                new SportsTree(7, "Rugby", "https://new.hollywoodbets.net/assets/images/icons/rugby.svg"),
                new SportsTree(8, "Cricket", "https://new.hollywoodbets.net/assets/images/icons/cricket.svg"),
                new SportsTree(9, "Golf", "https://new.hollywoodbets.net/assets/images/icons/golf.svg"),
                new SportsTree(10, "Aussie Rules", "https://new.hollywoodbets.net/assets/images/icons/aussie-rules.svg"),
                new SportsTree(11, "Bandy", "https://new.hollywoodbets.net/assets/images/icons/bandy.svg"),
                new SportsTree(12, "BasketBall", "https://new.hollywoodbets.net/assets/images/icons/basketball.svg"),
                new SportsTree(13, "Bowls", "https://new.hollywoodbets.net/assets/images/icons/bowls.svg"),
                new SportsTree(14, "Boxing", "https://new.hollywoodbets.net/assets/images/icons/boxing.svg"),
                new SportsTree(15, "Darts", "https://new.hollywoodbets.net/assets/images/icons/darts.svg"),
                new SportsTree(16, "Futsal", "https://new.hollywoodbets.net/assets/images/icons/futsal.svg"),
                new SportsTree(17, "Ice Hockey", "https://new.hollywoodbets.net/assets/images/icons/ice-hockey.svg"),
                new SportsTree(18, "MMA", "https://new.hollywoodbets.net/assets/images/icons/mma.svg"),
                new SportsTree(19, "Motorsport", "https://new.hollywoodbets.net/assets/images/icons/motorsport.svg"),
                new SportsTree(20, "Table Tennis", "https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportsTree(21, "Vollyball", "https://new.hollywoodbets.net/assets/images/icons/volleyball.svg")
            };
            return SportsList;
        }
        public static List<SportsCountry> SportsCountries()
        {
            SportsCountList = new List<SportsCountry>()
            {
                new SportsCountry(1,1),
                new SportsCountry(2,1),
                new SportsCountry(3,1),
                new SportsCountry(1,2),
               new SportsCountry(2,3),
                new SportsCountry(3,4),
                new SportsCountry(5,1),
                 new SportsCountry(5,2),
                  new SportsCountry(5,3),
                   new SportsCountry(5,4),
                    new SportsCountry(5,5),
                     new SportsCountry(5,6),


            };
            return SportsCountList;
        }
        public static List<BetTyp> BetTypsList = BetTyps();
        public static List<TournamentBetType> TournamentBetTypesList = TournamentBets();

        public static IEnumerable<Country> GetCountries(int? id)
        {
            var sport = Data.SportsCountries().Where(x => x.SportId == id);
            var matched = from country in Data.Countries()
                          where sport.Any(x => x.CountryId == country.CountryId)
                          select country;
            return matched;
        }
        public static List<Country> Countries()
        {
            CountrList = new List<Country>()
            {
                new Country(1,"South Africa","ZA"),
                new Country(2,"France","FR"),
                new Country(3,"England","ENG"),
                new Country(4,"Spain","SPN"),
                new Country(5,"Germany","DE"),
                new Country(6,"Wales","WLS"),
                new Country(7,"Finland","FI"),
                new Country(8,"Italy","IT"),
                new Country(9,"Cambodia","KH")


            };
            return CountrList;
        }

        public static List<Tournament> Tournaments()
        {
            return TournamentsList = new List<Tournament>()
            {
                new Tournament(1,"LaLiga"),
                new Tournament(2,"Barclays"),
                new Tournament(3,"English Premier Luege"),
                new Tournament(4,"PSL"),
                new Tournament(5,"T20 World Cup 2015"),
                new Tournament(6,"ODI World Cup 2015"),
                new Tournament(7,"ICC Champions Trophy 2013"),
                new Tournament(8 ,"ICC U-19 World Cup 2014"),
                new Tournament(10,"Currie Cup"),
                new Tournament(11,"Varsity Rugby"),
                new Tournament(12,"Gold Cup"),
                new Tournament(13,"Welsh Premier Division"),
                new Tournament(14,"WRU Division Two East"),
                new Tournament(15,"Masters"),
                new Tournament(16,"PGA Championship"),
                new Tournament(17,"U.S. Open"),
                new Tournament(18,"UEFA")
            };
        }
        public static List<SportTournament> SportTournaments()
        {
            return SportTournamentsList = new List<SportTournament>()
            {
                new SportTournament(1,15,3),
                new SportTournament(3,15,3),
                new SportTournament(2,1,1),
                new SportTournament(5,4,1),
                new SportTournament(5,1,3),
                new SportTournament(5,2,2),
                new SportTournament(5,3,3),
                new SportTournament(5,1,4)
            };
        }
        public static List<Event> Events()
        {
            return EventsList = new List<Event>()
            {
                new Event(1,1,"Atletico Bilbao vs Real Betis",new DateTime(2020, 3, 26, 7, 20, 0)),
                new Event(2,1,"Celta Vigo vs Real Betis",new DateTime(2020, 3, 27, 7, 20, 0)),
                new Event(3,1,"Getafe  vs Eibar",new DateTime(2020, 3, 29, 7, 20, 0)),
                new Event(4,1,"Real Sociedad  vs Real Madrid",new DateTime(2020, 3, 30, 7, 20, 0)),
                new Event(5,2,"English vs Afrikans",new DateTime(2020, 3, 31, 7, 20, 0)),
                new Event(6,2,"Batman vs Superman",new DateTime(2020, 4, 01, 7, 20, 0)),
                new Event(7,2,"Flash vs Batman",new DateTime(2020, 3, 26, 7, 20, 0)),
                new Event(8,4,"Chiefs vs Orlando Pirates",new DateTime(2020, 3, 26, 7, 20, 0)),
                new Event(8,4,"Chiefs vs SunDowns",new DateTime(2020, 3, 26, 7, 20, 0)),
                new Event(8,4,"Amazulu vs Orlando Pirates",new DateTime(2020, 3, 26, 7, 20, 0))

            };
        }

        public static IEnumerable<Event>EventsByToournament(int ? tournamentId)
        {
            return Events().Where(x => x.TournamentId == tournamentId);
        }
        public static List<BetTyp> BetTyps()
        {
            return BetTypsList = new List<BetTyp>()
            {
                new BetTyp(1,"Full Time"),
                new BetTyp(2,"Double Chance"),
                new BetTyp(3,"Both Teams To Score"),
                new BetTyp(4,"Half Time"),
                new BetTyp(5,"Handicap"),
            };
        }
        public static List<TournamentBetType> TournamentBets()
        {
            return TournamentBetTypesList = new List<TournamentBetType>()
            {
                new TournamentBetType(1,1, new List<int>{ 1,2,3,4,5}),
                new TournamentBetType(1,2, new List<int>{ 1,2,3}),
                new TournamentBetType(1,3, new List<int>{ 1,2,5}),
                new TournamentBetType(1,4, new List<int>{ 1,2,3,4,5}),
                new TournamentBetType(1,5, new List<int>{ 1,2,3,4,5})

            };
        }

    }
}
