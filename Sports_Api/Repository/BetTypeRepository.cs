using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class BetTypeRepository : IBetTypeRepository
    {
        private readonly HollywoodBetsRepDbContext _context;
        public BetTypeRepository(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }

        public void Add(BetType betType)
        {
            _context.BetType.Add(betType);
            _context.SaveChanges();
        }

        public void Delete(int? betTypeId)
        {
            var DbRecord = FInd(betTypeId);
            _context.BetType.Remove(DbRecord);
            _context.SaveChanges();
        }

        public BetType FInd(int? betTypeId)
        {
            return _context.BetType.Find(betTypeId);
        }

        public IQueryable<BetType> Get()
        {
            return _context.BetType;
        }

        public IQueryable<BetType> GetBetTypesForTournament(int? tournamentId)
        {
                string commandText = $"[dbo].[GetBetTypesForTournament] @tournamentId={tournamentId}";
                return ExecuteSql(commandText);

        }

        public void Update(BetType betType)
        {
            _context.Entry(betType).State = EntityState.Modified;
            _context.SaveChanges();
        }

        private IQueryable<BetType> ExecuteSql(string commandText)
        {
            return _context.BetType.FromSqlRaw(commandText);
        }
    }
}
