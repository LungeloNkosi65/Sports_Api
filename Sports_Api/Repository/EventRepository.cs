using Microsoft.EntityFrameworkCore;
using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class EventRepository : IEventRepository 
    {
        private readonly HollywoodBetsRepDbContext _context;
        public EventRepository(HollywoodBetsRepDbContext hollywoodBetsRepDbContext)
        {
            _context = hollywoodBetsRepDbContext;
        }

        public void Add(Event entity)
        {
            _context.Event.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int? eventId)
        {
            var dbRecord = Find(eventId);
            _context.Event.Remove(dbRecord);
            _context.SaveChanges();
        }

        public IQueryable<Event> ExecuteSql()
        {
            throw new NotImplementedException();
        }

        public Event Find(int? eventId)
        {
            return _context.Event.Find(eventId);
        }

        public IQueryable<Event> Get()
        {
            return _context.Event;
        }
        public IQueryable<EventVm> GetAllVm()
        {
            string commandText = "[dbo].[Event_Ids] ";
            return ExecuteSqlVm(commandText);
        }



        public IQueryable<Event> GetEventsForTournament(int? tournamentId)
        {
                string commandText = $"[dbo].[GetEventsForTournament] @tournamentId={tournamentId}";
                return ExecuteSql(commandText);
        }

        public IQueryable<Event> GetSingleEvent(int? eventId)
        {
                return _context.Event.Where(x => x.EventId == eventId);
        }

        public void Update(Event entitity)
        {
            _context.Entry(entitity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        private IQueryable<Event> ExecuteSql(string commandText)
        {
            return _context.Event.FromSqlRaw($"{commandText}");
        }


        private IQueryable<EventVm> ExecuteSqlVm(string commandText)
        {
            return _context.EventVm.FromSqlRaw($"{commandText}").AsQueryable();
        }

    }
}
