using Sports_Api.Repository.Interfaces;
using Sports_Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services.Implementations
{
    public class BonusTblService : IBonusTblService
    {
        private readonly IBonusTblRepository _bonusTblRepository;

        public BonusTblService(IBonusTblRepository bonusTblRepository)
        {
            _bonusTblRepository = bonusTblRepository;
        }
        public void Add(BonusTbl bonusTbl)
        {
            _bonusTblRepository.Add(bonusTbl);
        }

        public void delete(int? bonusId)
        {
            _bonusTblRepository.delete(bonusId);
        }

        public BonusTbl Find(int? bonusId)
        {
           return _bonusTblRepository.Find(bonusId);
        }

        public IQueryable<BonusTbl> GetAll()
        {
            return _bonusTblRepository.GetAll();
        }

        public IQueryable<BonusTbl> GetSingle(int? bonusId)
        {
            return _bonusTblRepository.GetSingle(bonusId);
        }

        public void update(BonusTbl bonusTbl)
        {
            _bonusTblRepository.update(bonusTbl);
        }
    }
}
