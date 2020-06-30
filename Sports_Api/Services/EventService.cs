using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public Event Find(int? eventId)
        {
            return _eventRepository.Find(eventId);
        }

        public IQueryable<Event> Get()
        {
            return _eventRepository.Get();
        }

        public IQueryable<Event> GetEventForTournament(int? tournamentId)
        {
            return _eventRepository.GetEventsForTournament(tournamentId);
        }

        public IQueryable<Event> GetSingleEvent(int? eventId)
        {
            return _eventRepository.GetSingleEvent(eventId);
        }
    }
}
