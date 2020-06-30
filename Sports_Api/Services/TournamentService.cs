using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class TournamentService : ITournamentService
    {
        private readonly ITournamentRepository _tournamentRepository;

        public TournamentService(ITournamentRepository tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }
        public IQueryable<Tournament> Get()
        {
            return _tournamentRepository.Get();
        }

        public IQueryable<Tournament> GetSingleTournament(int? tournamentId)
        {
            return _tournamentRepository.GetSingleTournament(tournamentId);
        }

        public IQueryable<Tournament> GetTournamentsForSport(int ?sportId, int ? countryId)
        {
            return _tournamentRepository.GetTournamentsForSport(sportId, countryId);
        }
    }
}
