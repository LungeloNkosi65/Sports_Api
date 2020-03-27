using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class TournamentBetType
    {
        public int TbTId { get; set; }
        public int TournamentId { get; set; }
        public List<int> BetTypes { get; set; }

        public TournamentBetType(int tbtId, int tournamentId, List<int> betTypes)
        {
            TbTId = tbtId;
            TournamentId = tournamentId;
            BetTypes = betTypes;

        }
    }
}
