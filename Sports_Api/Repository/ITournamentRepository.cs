using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
   public interface ITournamentRepository
    {
        IQueryable<Tournament> Get();
        IQueryable<Tournament> GetSingleTournament(int? tournamentId);

        IQueryable<Tournament> GetTournamentsForSport(int ?sportId, int? countryId);

        Tournament Find(int? tournamentId);
    }
}
