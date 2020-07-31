using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class TournamentRepository : ITournamentRepository
    {
        private readonly HollywoodBetsRepDbContext _context;
        public TournamentRepository(HollywoodBetsRepDbContext hollywoodBetsRepDbContext)
        {
            _context = hollywoodBetsRepDbContext;
        }

        public Tournament Add(Tournament tournament)
        {
            
                _context.Tournament.Add(tournament);
                _context.SaveChanges();
                return tournament;
           
        }

        public void delete(int? tournamentId)
        {
            var dbRecord = Find(tournamentId);  // this will return an object with one record from the db
           _context.Tournament.Remove(dbRecord);
            _context.SaveChanges();
          
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
            
                return _context.Tournament.Where(x => x.TournamentId == tournamentId);
           
        }

        public IQueryable<Tournament> GetTournamentsForSport(int? sportId, int? countryId)
        {
                string commandText = $"[dbo].[GetTournaments] @sportId={sportId}, @countryId={countryId}";
                return ExecuteSql(commandText);
        }

        public void Update(Tournament tournament)
        {
                _context.Entry(tournament).State = EntityState.Modified;
                _context.SaveChanges();
        }

        private IQueryable<Tournament> ExecuteSql(string commandText)
        {
            return _context.Tournament.FromSqlRaw($"{commandText}").AsQueryable();
        }
    }
}
