using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class SportTournamentService:ISportTournamentService
    {
        private readonly ISportTournamentRepository _sportTournamentRepository;
        public SportTournamentService(ISportTournamentRepository sportTournamentRepository)
        {
            _sportTournamentRepository = sportTournamentRepository;
        }

        public void Add(SportsTournament sportsTournament)
        {
            _sportTournamentRepository.Add(sportsTournament);
        }

        public void Delete(int? sportTourtnamentId)
        {
            _sportTournamentRepository.Delete(sportTourtnamentId);
        }

        public SportsTournament Find(int? sportTourtnamentId)
        {
            return _sportTournamentRepository.Find(sportTourtnamentId);
        }

        public IQueryable<SportsTournament> GetAll()
        {
            return _sportTournamentRepository.GetAll();
        }

        public IQueryable<SportsTournament> getSingleSportTournament(int? sportTourtnamentId)
        {
            return _sportTournamentRepository.getSingleSportTournament(sportTourtnamentId);
        }

        public void Update(SportsTournament sportsTournament)
        {
            _sportTournamentRepository.Update(sportsTournament);
        }
    }
}
