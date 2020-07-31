using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class MarketRepository : IMarketRepository
    {
        private readonly HollywoodBetsRepDbContext _context;
        public MarketRepository(HollywoodBetsRepDbContext hollywoodBetsRepDbContext)
        {
            _context = hollywoodBetsRepDbContext;
        }

        public void Add(Market market)
        {
            _context.Market.Add(market);
            _context.SaveChanges();
        }

        public void Delete(int? marketId)
        {
            var dbRecord = Find(marketId);
            _context.Market.Remove(dbRecord);
            _context.SaveChanges();
        }

        public Market Find(int? markeyId)
        {
            return _context.Market.Find(markeyId);
        }

        public IQueryable<Market> Get()
        {
            return _context.Market;
        }

        public IQueryable<Market> GetMarketsForBetType(int? betTypeId)
        {
            string commandText = $"[dbo].[GetMarketsForBetType] @betTypeId={betTypeId}";
            return ExecuteSql(commandText);
        }

        public IQueryable<Market> GetSingle(int? marletId)
        {
          return  _context.Market.Where(x => x.MarketId == marletId).AsQueryable();
        }

        public void Update(Market market)
        {
            _context.Entry(market).State = EntityState.Modified;
            _context.SaveChanges();
        }

        private IQueryable<Market> ExecuteSql(string commandText)
        {
            return _context.Market.FromSqlRaw(commandText);
        }
    }
}
