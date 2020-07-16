using Sports_Api.Models.CustomModel;
using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class SportCountryService : ISportCountryService
    {
        private readonly ISportCountryRepository _sportCountry;

        public SportCountryService(ISportCountryRepository sportCountry)
        {
            _sportCountry = sportCountry;
        }
        public void Add(SportCountry sportCountry)
        {
            _sportCountry.Add(sportCountry);
        }

        public void delete(int? sportCountryId)
        {
            _sportCountry.delete(sportCountryId);
        }

        public IQueryable<SportCountry> Get()
        {
            return _sportCountry.Get();
        }

        public void Update(SportCountry sportCountry)
        {
            _sportCountry.Update(sportCountry);
        }

        public IQueryable<SportCountryViewModel> ViewGet()
        {
            return _sportCountry.ViewGet();
        }
    }
}
