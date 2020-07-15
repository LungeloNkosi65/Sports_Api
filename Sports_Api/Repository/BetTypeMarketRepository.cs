using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class BetTypeMarketRepository : IBetTypeMarketRepository
    {
        private readonly HollywoodBetsRepDbContext _context;

        public BetTypeMarketRepository(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }
        public void Add(BetTypeMarket betTypeMarket)
        {
            _context.BetTypeMarket.Add(betTypeMarket);
            _context.SaveChanges();
        }

        public void Delete(int? betTypeMarketId)
        {
            var dbRecord = Find(betTypeMarketId);
            _context.BetTypeMarket.Remove(dbRecord);
            _context.SaveChanges();
        }

        public BetTypeMarket Find(int? betTypeMarketId)
        {
            return _context.BetTypeMarket.Find(betTypeMarketId);
        }

        public IQueryable<BetTypeMarket> Get(int? betTypeMarketId)
        {
            return _context.BetTypeMarket.Where(x => x.BetTypeMarketId == betTypeMarketId).AsQueryable();
        }

        public IQueryable<BetTypeMarket> GetAll()
        {
            return _context.BetTypeMarket.AsQueryable();
        }

        public void Update(BetTypeMarket betTypeMarket)
        {
            _context.Entry(betTypeMarket).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
