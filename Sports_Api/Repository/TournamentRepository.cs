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
            try
            {
                _context.Tournament.Add(tournament);
                _context.SaveChanges();
                return tournament;
            }
            catch (Exception)
            {

                throw new ArgumentNullException("Invalid Data Submited");
            }
        }

        public void delete(int? tournamentId)
        {
            var dbRecord = Find(tournamentId);  // this will return an object with one record from the db
            try
            {
                _context.Tournament.Remove(dbRecord);
            }
            catch (Exception)
            {

                throw new ArgumentNullException("Invalid Id submited");
            }
        }

        public Tournament Find(int? tournamentId)
        {
            try
            {
                return _context.Tournament.Find(tournamentId);

            }
            catch (Exception)
            {

                throw new ArgumentNullException("tournamentId not found");
            }
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

               throw  new ArgumentNullException("Invalid TournamentId");
            }
        }

        public IQueryable<Tournament> GetTournamentsForSport(int? sportId, int? countryId)
        {
                string commandText = $"[dbo].[GetTournaments] @sportId={sportId}, @countryId={countryId}";
                return ExecuteSql(commandText);
        }

        public void Update(Tournament tournament)
        {
            try
            {
                _context.Entry(tournament).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new ArgumentNullException("Invalid data submited");
            }
        }

        private IQueryable<Tournament> ExecuteSql(string commandText)
        {
            return _context.Tournament.FromSqlRaw($"{commandText}").AsQueryable();
        }
    }
}
