using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
   public interface ITournamentService
    {
        IQueryable<Tournament> Get();
        IQueryable<Tournament> GetSingleTournament(int? tournamentId);
        IQueryable<Tournament> GetTournamentsForSport(int ?sportId, int? countryId);
    }
}
