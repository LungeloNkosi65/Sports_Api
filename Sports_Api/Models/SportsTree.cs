using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class SportsTree
    {
        public SportsTree()
        {
            SportCountry = new HashSet<SportCountry>();
            SportsTournament = new HashSet<SportsTournament>();
        }
        [Key]

        public int SportId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public virtual ICollection<BetTbl> BetTbl { get; set; }
        public virtual ICollection<SportCountry> SportCountry { get; set; }
        public virtual ICollection<SportsTournament> SportsTournament { get; set; }
    }
}
