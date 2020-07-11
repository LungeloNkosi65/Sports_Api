using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class MarketService : IMarketService
    {
        private readonly IMarketRepository _marketRepository;

        public MarketService(IMarketRepository marketService)
        {
            _marketRepository = marketService;
        }
        public IQueryable<Market> Get()
        {
            return _marketRepository.Get();
        }

        public IQueryable<Market> GetMarketsForBetType(int? betTypeId)
        {
            return _marketRepository.GetMarketsForBetType(betTypeId);
        }
    }
}
