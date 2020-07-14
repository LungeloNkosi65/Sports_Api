using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
   public  interface ISportCountryService
    {
        void Add(SportCountry sportCountry);
        void delete(int? sportCountryId);
        void Update(SportCountry sportCountry);
        IQueryable<SportCountry> Get();
    }
}
