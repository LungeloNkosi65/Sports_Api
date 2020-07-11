using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly HollywoodBetsRepDbContext _context;
        public CountryRepository(HollywoodBetsRepDbContext hollywoodBetsRepDbContext)
        {
            _context = hollywoodBetsRepDbContext;
        }


        public Country Find(int? countryId)
        {
            return _context.Country.Find(countryId);
        }

        public IQueryable<Country> Get()
        {
            return _context.Country;
        }

        public IQueryable<Country> Get(int? countryId)
        {
            return _context.Country.Where(x => x.CountryId == countryId);
        }

        public IQueryable<Country> CountryForSport(int? sportId)
        {
            string commandText = "[dbo].[GetCountriesForSport] @sportId=" + sportId;
            try
            {
                return RunCountrySql(commandText);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private IQueryable<Country> RunCountrySql(string sqlStatement)
        {
            return _context.Country.FromSqlRaw($"{sqlStatement}").AsQueryable();
        }
    }
}
