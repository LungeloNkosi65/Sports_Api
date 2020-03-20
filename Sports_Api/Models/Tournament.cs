using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public string Name { get; set; }
        public Tournament(int id,string name)
        {
            TournamentId = id;
            Name = name;
        }
    }
}
