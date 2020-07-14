using Sports_Api.Models.CustomModel;
using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class BetService : IBetService
    {
        private readonly IBetRepository _betRepository;
        public BetService(IBetRepository betRepository )
        {
            _betRepository = betRepository;
        }
        public void CancellBet(int? betId)
        {
            _betRepository.CancellBet(betId);
        }

        public BetTbl Find(int? betId)
        {
            return _betRepository.Find(betId);
        }

        public void PlaceBet(SubmitedBet submitedBet)
        {
            _betRepository.PlaceBet(submitedBet);
        }

        public IQueryable<BetTbl> RecentBets(string accountNumber)
        {
            return _betRepository.RecentBets(accountNumber);
        }
    }
}
