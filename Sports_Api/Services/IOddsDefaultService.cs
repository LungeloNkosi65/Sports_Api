using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public interface IOddsDefaultService
    {
        void Delete(int? oddId);

        void Update(Odds odds);
        void Add(Odds odds);

        Odds Find(int? oddId);

        IQueryable<Odds> GetOdds();
        IQueryable<Odds> GetSingleOdd(int? oddId);
    }
}
