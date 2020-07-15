using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class TournamentBetTypeService : ITournamentBetTypeService
    {
        private readonly ITournamentBetTypeRepository _tournamentBetType;
        public TournamentBetTypeService(ITournamentBetTypeRepository tournamentBetType)
        {
            _tournamentBetType = tournamentBetType;
        }
        public void Add(TournamentBetType tournamentBetType)
        {
            _tournamentBetType.Add(tournamentBetType);
        }

        public void Delete(int? tbTid)
        {
            _tournamentBetType.Delete(tbTid);
        }

        public TournamentBetType Find(int? tbTid)
        {
            return _tournamentBetType.Find(tbTid);
        }

        public IQueryable<TournamentBetType> Get(int? tbTid)
        {
            return _tournamentBetType.Get(tbTid);
        }

        public IQueryable<TournamentBetType> GetAll()
        {
          return  _tournamentBetType.GetAll();
        }

        public void Update(TournamentBetType tournamentBetType)
        {
            _tournamentBetType.Update(tournamentBetType);
        }
    }
}
