using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Flag { get; set; }
        public Country(int id,string name,string flag)
        {
            CountryId = id;
            CountryName = name;
            Flag = flag;
        }
    }
}
