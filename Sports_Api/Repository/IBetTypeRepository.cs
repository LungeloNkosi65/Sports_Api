using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public interface IBetTypeRepository
    {
        IQueryable<BetType> Get();
        IQueryable<BetType> GetBetTypesForTournament(int? tournamentId);
        BetType FInd(int? betTypeId);
    }
}
