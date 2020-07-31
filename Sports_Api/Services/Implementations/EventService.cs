using Sports_Api.Models.CustomModel;
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

        public void Add(Event entity)
        {
            _eventRepository.Add(entity);
        }

        public void Delete(int? eventId)
        {
            _eventRepository.Delete(eventId);
        }

        public Event Find(int? eventId)
        {
            return _eventRepository.Find(eventId);
        }

        public IQueryable<Event> Get()
        {
            return _eventRepository.Get();
        }

        public IQueryable<EventVm> GetAllVm()
        {
            return _eventRepository.GetAllVm();
        }

        public IQueryable<Event> GetEventForTournament(int? tournamentId)
        {
            return _eventRepository.GetEventsForTournament(tournamentId);
        }

        public IQueryable<Event> GetSingleEvent(int? eventId)
        {
            return _eventRepository.GetSingleEvent(eventId);
        }

        public void Update(Event entitity)
        {
            _eventRepository.Update(entitity);
        }
    }
}
