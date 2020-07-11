using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class BetTypeService : IBetTypeService
    {
        private readonly IBetTypeRepository _betTypeRepository;
        public BetTypeService(IBetTypeRepository betTypeRepository)
        {
            _betTypeRepository = betTypeRepository;
        }
        public BetType Find(int? betTypeId)
        {
            return _betTypeRepository.FInd(betTypeId);
        }

        public IQueryable<BetType> Get()
        {
            return _betTypeRepository.Get();
        }

        public IQueryable<BetType> GetBetTypesForTournament(int? tournamentId)
        {
            return _betTypeRepository.GetBetTypesForTournament(tournamentId);
        }
    }
}
