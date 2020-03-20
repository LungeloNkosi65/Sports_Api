using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class Data
    {
        public static List<Country> CountrList = Countries();
        public static List<SportsCountry> SportsCountList = SportsCountries();
        public static List<Tournament> TournamentsList = Tournaments();
        public static List<SportTournament> SportTournamentsList = SportTournaments();

     
        public static List<SportsCountry> SportsCountries()
        {
            SportsCountList = new List<SportsCountry>()
            {
                new SportsCountry(1,1),
                new SportsCountry(2,1),
                new SportsCountry(3,1),
                new SportsCountry(1,2),
               new SportsCountry(2,3),
                new SportsCountry(3,4)
            };
            return SportsCountList;
        }

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
                new Country(1,"South Africa","SA"),
                new Country(2,"France","FRA"),
                new Country(3,"England","ENG"),
                new Country(4,"Spain","SPN"),
                new Country(5,"Germany","GMN"),
                  new Country(6,"Wales","GMN")
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
                new Tournament(17,"U.S. Open")
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
                new SportTournament(5,2,1),
                new SportTournament(5,4,3),
                new SportTournament(5,1,4)
            };
        }

    }
}
