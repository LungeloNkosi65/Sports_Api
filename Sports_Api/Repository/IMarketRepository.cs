using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public interface IMarketRepository
    {
        IQueryable<Market> Get();
        IQueryable<Market> GetMarketsForBetType(int? betTypeId);
        void Add(Market market);

        void Delete(int? marketId);

        void Update(Market market);
        Market Find(int? markeyId);
        IQueryable<Market> GetSingle(int? marletId);

    }
}//using System;


