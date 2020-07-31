using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
   public interface IOddsDefaultRepository
    {
        IQueryable<OddsViewModel> GetAll();
        void Delete(int? oddId);

        void Update(Odds odds);
        void Add(Odds odds);

        Odds Find(int? oddId);

        IQueryable<Odds> GetOdds();
        IQueryable<Odds> GetSingleOdd(int? oddId);
    }
}
