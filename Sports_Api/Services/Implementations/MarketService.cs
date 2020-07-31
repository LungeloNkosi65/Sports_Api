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

        public void Add(Market market)
        {
            _marketRepository.Add(market);
        }

        public void delete(int? marketId)
        {
            _marketRepository.Delete(marketId);
        }

        public Market Find(int? marketId)
        {
            return _marketRepository.Find(marketId);
        }

        public IQueryable<Market> Get()
        {
            return _marketRepository.Get();
        }

        public IQueryable<Market> GetMarketsForBetType(int? betTypeId)
        {
            return _marketRepository.GetMarketsForBetType(betTypeId);
        }

        public IQueryable<Market> GetSingle(int? marketId)
        {
            return _marketRepository.GetSingle(marketId);
        }

        public void update(Market market)
        {
            _marketRepository.Update(market);
        }
    }
}
