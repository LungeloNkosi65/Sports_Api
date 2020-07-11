using Microsoft.EntityFrameworkCore;
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
        public Event Find(int? eventId)
        {
            return _context.Event.Find(eventId);
        }

        public IQueryable<Event> Get()
        {
            return _context.Event;
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


        private IQueryable<Event> ExecuteSql(string commandText)
        {
            return _context.Event.FromSqlRaw($"{commandText}");
        }
    }
}
