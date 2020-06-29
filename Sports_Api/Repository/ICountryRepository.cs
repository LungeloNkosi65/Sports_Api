using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public interface ICountryRepository
    {
        IQueryable<Country> Get();
        IQueryable<Country> Get(int ? countryId);
        Country Find(int? countryId);

        IQueryable<Country> CountryForSport(int ? sportId);
    }
}
