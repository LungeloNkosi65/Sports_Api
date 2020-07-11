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

    }
}//using System;


