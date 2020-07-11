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
        public IQueryable<Market> Get()
        {
            return _context.Market;
        }

        public IQueryable<Market> GetMarketsForBetType(int? betTypeId)
        {
            string commandText = $"[dbo].[GetMarketsForBetType] @betTypeId={betTypeId}";
            return ExecuteSql(commandText);
        }

        private IQueryable<Market> ExecuteSql(string commandText)
        {
            return _context.Market.FromSqlRaw(commandText);
        }
    }
}
