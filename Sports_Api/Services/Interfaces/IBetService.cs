﻿using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public interface IBetService
    {
        void PlaceBet(SubmitedBet submitedBet);
        void CancellBet(int? betId);
        IQueryable<BetTbl> RecentBets(string accountNumber);

        BetTbl Find(int? betId);
        IQueryable<BetSlip> GetBets();
        IQueryable<BetTbl> GetBetEvents();
        IQueryable<RecentBetsVm> GetRecentBets(string userAccount);


        IQueryable<RecentBetsVm> FilterBets(string ?userAccount,DateTime? startDate, DateTime? endDate);
        

    }
}
