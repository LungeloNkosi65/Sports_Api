using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class SportCountryRepository : ISportCountryRepository
    {
        private readonly HollywoodBetsRepDbContext _context;

        public SportCountryRepository(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }
        public void Add(SportCountry sportCountry)
        {
            _context.SportCountry.Add(sportCountry);
            _context.SaveChanges();
        }

        public void delete(int? sportCountryId)
        {
            var dbRecord = _context.SportCountry.Find(sportCountryId);
            _context.SportCountry.Remove(dbRecord);
            _context.SaveChanges();
        }

        public IQueryable<SportCountry> Get()
        {
            return _context.SportCountry.AsQueryable();
        }

        public void Update(SportCountry sportCountry)
        {
            _context.Entry(sportCountry).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
