using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
   public interface IOddsService
    {
        IQueryable<CustomOdds> Get();
        IQueryable<CustomOdds> GetOddsForEvent(int ?  tournamentId);
    }
}
