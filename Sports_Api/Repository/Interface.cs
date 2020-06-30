using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
   public interface IEventRepository
    {
        IQueryable<Event> Get();
        IQueryable<Event> GetSingleEvent(int? eventId);
        IQueryable<Event> GetEventsForTournament(int? tournamentId);
        Event Find(int? eventId);
    }
}
