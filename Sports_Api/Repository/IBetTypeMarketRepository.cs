using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public interface IBetTypeMarketRepository
    {
        IQueryable<BetTypeMarket> GetAll();
        IQueryable<BetTypeMarketVm> GetAllVm();

        IQueryable<BetTypeMarket> Get(int? betTypeMarketId);
        void Add(BetTypeMarket betTypeMarket);
        void Update(BetTypeMarket betTypeMarket);
        void Delete(int? betTypeMarketId);
        BetTypeMarket Find(int? betTypeMarketId);
    }
}
