using Sports_Api.Models.CustomModel;
using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class BetTypeMarketService : IBetTypeMarketService
    {
        private readonly IBetTypeMarketRepository _betTypeMarketRepository;
        public BetTypeMarketService(IBetTypeMarketRepository betTypeMarketRepository)
        {
            _betTypeMarketRepository = betTypeMarketRepository;
        }
        public void Add(BetTypeMarket betTypeMarket)
        {
            _betTypeMarketRepository.Add(betTypeMarket);
        }

        public void Delete(int? betTypeMarketId)
        {
            _betTypeMarketRepository.Delete(betTypeMarketId);
        }

        public BetTypeMarket Find(int? betTypeMarketId)
        {
          return  _betTypeMarketRepository.Find(betTypeMarketId);
        }

        public IQueryable<BetTypeMarket> Get(int? betTypeMarketId)
        {
            return _betTypeMarketRepository.Get(betTypeMarketId);
        }

        public IQueryable<BetTypeMarket> GetAll()
        {
            return _betTypeMarketRepository.GetAll();
        }

        public IQueryable<BetTypeMarketVm> GetAllVm()
        {
            return _betTypeMarketRepository.GetAllVm();
        }

        public void Update(BetTypeMarket betTypeMarket)
        {
            _betTypeMarketRepository.Update(betTypeMarket);
        }
    }
}
