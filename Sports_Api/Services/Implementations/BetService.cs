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

        public IQueryable<RecentBetsVm> FilterBets(string userAccount, DateTime? startDate, DateTime? endDate)
        {
            var dbRecord = GetRecentBets(userAccount);
            //if (endDate == null)
            //{
            //    //return dbRecord.Where(x=>x.Date betw)
            //}
            return dbRecord;
        }

        public BetTbl Find(int? betId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BetTbl> GetBetEvents()
        {
            return _betRepository.GetBetEvents();
        }

        public IQueryable<BetSlip> GetBets()
        {
            return _betRepository.GetBets();
        }

        public IQueryable<RecentBetsVm> GetRecentBets(string userAccount)
        {
            return _betRepository.GetRecentBets(userAccount);
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
