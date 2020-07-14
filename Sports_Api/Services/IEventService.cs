using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public interface IEventService
    {
        IQueryable<Event> Get();
        IQueryable<Event> GetSingleEvent(int? eventId);
        IQueryable<Event> GetEventForTournament(int? tournamentId);
        Event Find(int? eventId);
        void Add(Event entity);
        void Update(Event entitity);
        void Delete(int? eventId);
    }
}
