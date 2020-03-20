using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class SportsTree
    {
        public int SportId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        
        public SportsTree(int id, string name,string logo)
        {
            SportId = id;
            Name = name;
            Logo = logo;
        }
    }
}
