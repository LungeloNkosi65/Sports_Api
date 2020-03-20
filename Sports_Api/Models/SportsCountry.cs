using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class SportsCountry
    {
        public int SportId { get; set; }
        public int CountryId { get; set; }

        public SportsCountry(int sportId,int countryId)
        {
            SportId = sportId;
            CountryId = countryId;
        }
    }
}
