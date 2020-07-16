using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public interface IMarketService
    {
        IQueryable<Market> Get();
        IQueryable<Market> GetMarketsForBetType(int? betTypeId);

        IQueryable<Market> GetSingle(int? marketId);

        Market Find(int? marketId);

        void Add(Market market);
        void update(Market market);
        void delete(int? marketId);
    }
}
