﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services.Interfaces
{
   public interface IBonusTblService
    {
        IQueryable<BonusTbl> GetAll();
        IQueryable<BonusTbl> GetSingle(int? bonusId);
        BonusTbl Find(int? bonusId);

        void Add(BonusTbl bonusTbl);
        void delete(int? bonusId);
        void update(BonusTbl bonusTbl);
    }
}
