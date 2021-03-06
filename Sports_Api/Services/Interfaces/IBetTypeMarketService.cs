﻿using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
   public interface IBetTypeMarketService
    {
        IQueryable<BetTypeMarket> GetAll();
        IQueryable<BetTypeMarketVm> Get(int? betTypeMarketId);
        void Add(BetTypeMarket betTypeMarket);
        void Update(BetTypeMarket betTypeMarket);
        void Delete(int? betTypeMarketId);
        BetTypeMarket Find(int? betTypeMarketId);
        IQueryable<BetTypeMarketVm> GetAllVm();
    }
}
