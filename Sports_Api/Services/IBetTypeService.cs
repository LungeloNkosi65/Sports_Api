using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public interface IBetTypeService
    {
        IQueryable<BetType> Get();
        IQueryable<BetType> GetBetTypesForTournament(int? tournamentId);
        BetType Find(int? betTypeId);
        void Add(BetType betType);
        void Delete(int? betTypeId);
        void Update(BetType betType);
    }
}
