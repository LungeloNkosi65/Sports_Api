using Microsoft.EntityFrameworkCore;
using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class OddsService : IOddsService
    {
        private readonly IOddsRepository _oddsRepository;

        public OddsService(IOddsRepository oddsRepository)
        {
            _oddsRepository = oddsRepository;
        }
        public IQueryable<CustomOdds> Get()
        {
           return _oddsRepository.Get();
        }

        public IQueryable<CustomOdds> GetOddsForEvent(int ? tournamentId)
        {
            return _oddsRepository.GetOddsForEvent(tournamentId);
        }
    }
}
