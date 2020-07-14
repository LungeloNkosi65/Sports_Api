using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
   public interface IBetRepository
    {
        void PlaceBet(SubmitedBet submitedBet);
        void CancellBet(int? betId);
        IQueryable<BetTbl> RecentBets(string accountNumber);

        BetTbl Find(int? betId);
    }
}
