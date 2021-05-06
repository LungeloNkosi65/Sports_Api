using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class Country
    {
        public Country()
        {
            SportCountry = new HashSet<SportCountry>();
            SportsTournament = new HashSet<SportsTournament>();
        }

        [Key]

        public int CountryId { get; set; }
            public string CountryName { get; set; }
            public string Flag { get; set; }

            public virtual ICollection<SportCountry> SportCountry { get; set; }
            public virtual ICollection<SportsTournament> SportsTournament { get; set; }
        }
    }
