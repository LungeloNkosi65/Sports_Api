using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class TournamentRepository:ITournamentRepository
    {
        private readonly HollywoodBetsRepDbContext _context;
        public TournamentRepository(HollywoodBetsRepDbContext hollywoodBetsRepDbContext)
        {
            _context = hollywoodBetsRepDbContext;
        }

        public Tournament Find(int? tournamentId)
        {
            return _context.Tournament.Find(tournamentId);
        }

        public IQueryable<Tournament> Get()
        {
            return _context.Tournament;
        }

        public IQueryable<Tournament> GetSingleTournament(int? tournamentId)
        {
            try
            {
                return _context.Tournament.Where(x => x.TournamentId == tournamentId);
            }
            catch (ArgumentNullException)
            {

                throw;
            }
        }

        public IQueryable<Tournament> GetTournamentsForSport(int ?sportId, int? countryId)
        {
            string commandText = $"[dbo].[GetTournaments] @sportId={sportId}, @countryId={countryId}";
            return ExecuteSql(commandText);
        }

        private IQueryable<Tournament> ExecuteSql(string commandText)
        {
            return _context.Tournament.FromSqlRaw($"{commandText}").AsQueryable();
        }
    }
}
