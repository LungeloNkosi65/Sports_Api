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
    }
}
