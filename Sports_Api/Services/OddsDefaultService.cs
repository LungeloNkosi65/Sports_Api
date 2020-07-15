using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class OddsDefaultService : IOddsDefaultService
    {
        private readonly IOddsDefaultRepository _defaultRepository;
        public OddsDefaultService(IOddsDefaultRepository defaultRepository)
        {
            _defaultRepository = defaultRepository;
        }
        public void Add(Odds odds)
        {
            _defaultRepository.Add(odds);
        }

        public void Delete(int? oddId)
        {
            _defaultRepository.Delete(oddId);
        }

        public Odds Find(int? oddId)
        {
            return _defaultRepository.Find(oddId);
        }

        public IQueryable<Odds> GetOdds()
        {
            return _defaultRepository.GetOdds();
        }

        public IQueryable<Odds> GetSingleOdd(int? oddId)
        {
            return _defaultRepository.GetSingleOdd(oddId);
        }

        public void Update(Odds odds)
        {
            _defaultRepository.Update(odds);
        }
    }
}
