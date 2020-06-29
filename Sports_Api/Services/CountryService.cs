using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryseRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryseRepository = countryRepository;
        }

        public IQueryable<Country> CountryForSport(int  sportId)
        {
            return _countryseRepository.CountryForSport(sportId);
        }

        public Country Find(int? countryId)
        {
            return _countryseRepository.Find(countryId);
        }

        public IQueryable<Country> Get()
        {
            return _countryseRepository.Get();
        }

        public IQueryable<Country> Get(int? countryId)
        {
            return _countryseRepository.Get(countryId);
        }
    }
}
