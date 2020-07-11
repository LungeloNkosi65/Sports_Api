using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class OddsRepository : IOddsRepository
    {
        private readonly HollywoodBetsRepDbContext _context;
        public OddsRepository(HollywoodBetsRepDbContext hollywoodBetsRepDbContext)
        {
            _context = hollywoodBetsRepDbContext;
        }
        public IQueryable<CustomOdds> Get()
        {
            return _context.CustomOdd ;
        }

        public IQueryable<CustomOdds> GetOddsForEvent(int ?tournamentId)
        {
            try
            {
                string commandText = $"[dbo].[GetOddsForEvent]  @tournamentId=${tournamentId}";
                return ExecuteSql(commandText);
            }
            catch (ArgumentNullException)
            {
                throw;
            }

        }

        private IQueryable<CustomOdds> ExecuteSql(string commandText)
        {
            return _context.CustomOdd.FromSqlRaw(commandText);
        }
    }
}
