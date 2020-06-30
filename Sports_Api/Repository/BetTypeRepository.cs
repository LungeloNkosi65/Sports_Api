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
            try
            {
                string commandText = $"[dbo].[GetBetTypesForTournament] @tournamentId={tournamentId}";
                return ExecuteSql(commandText);
            }
            catch (ArgumentNullException)
            {

                throw;
            }
            
        }

        private IQueryable<BetType>ExecuteSql(string commandText)
        {
            return _context.BetType.FromSqlRaw(commandText);
        }
    }
}
