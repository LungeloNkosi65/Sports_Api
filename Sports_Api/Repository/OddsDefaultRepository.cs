using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class OddsDefaultRepository : IOddsDefaultRepository
    {
        private readonly HollywoodBetsRepDbContext _context;

        public OddsDefaultRepository(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }
        public void Add(Odds odds)
        {
            _context.Odds.Add(odds);
            _context.SaveChanges();
        }

        public void Delete(int? oddId)
        {
            var dbRecord = Find(oddId);
            _context.Odds.Remove(dbRecord);
            _context.SaveChanges();
        }

        public Odds Find(int? oddId)
        {
            return _context.Odds.Find(oddId);
        }

        public IQueryable<Odds> GetOdds()
        {
            return _context.Odds.AsQueryable();
        }

        public IQueryable<Odds> GetSingleOdd(int? oddId)
        {
            return _context.Odds.Where(x => x.OddId == oddId).AsQueryable();
        }

        public void Update(Odds odds)
        {
            _context.Entry(odds).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
