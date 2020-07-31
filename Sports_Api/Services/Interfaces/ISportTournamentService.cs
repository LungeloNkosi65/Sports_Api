using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public interface ISportTournamentService
    {
        SportsTournament Find(int? sportTourtnamentId);
        void Add(SportsTournament sportsTournament);
        void Update(SportsTournament sportsTournament);
        void Delete(int? sportTourtnamentId);
        IQueryable<SportsTournament> getSingleSportTournament(int? sportTourtnamentId);
        IQueryable<SportsTournament> GetAll();
        IQueryable<SportsTournamentVm> GetAllVm();
    }
}
