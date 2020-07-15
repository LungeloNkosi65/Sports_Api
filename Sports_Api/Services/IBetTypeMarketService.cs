using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
   public interface IBetTypeMarketService
    {
        IQueryable<BetTypeMarket> GetAll();
        IQueryable<BetTypeMarket> Get(int? betTypeMarketId);
        void Add(BetTypeMarket betTypeMarket);
        void Update(BetTypeMarket betTypeMarket);
        void Delete(int? betTypeMarketId);
        BetTypeMarket Find(int? betTypeMarketId);
    }
}
