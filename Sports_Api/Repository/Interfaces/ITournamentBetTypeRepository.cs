using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
   public interface ITournamentBetTypeRepository
    {
        void Add(TournamentBetType tournamentBetType);

        void Update(TournamentBetType tournamentBetType);
        IQueryable<TournamentBetType> GetAll();
        IQueryable<TournamentBetType> Get(int? tbTid);
        void Delete(int? tbTid);

        TournamentBetType Find(int? tbTid);
        IQueryable<TournamentBetTypeVm> GetAllVm();
    }
}
