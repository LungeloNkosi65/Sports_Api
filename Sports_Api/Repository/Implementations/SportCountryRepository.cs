using Microsoft.EntityFrameworkCore;
using Sports_Api.Models.CustomModel;
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

        public IQueryable<SportCountry> GetSingle(int? sportCountryId)
        {
            return _context.SportCountry.Where(x => x.SportCountryId == sportCountryId).AsQueryable();
        }

        public void Update(SportCountry sportCountry)
        {
            _context.Entry(sportCountry).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IQueryable<SportCountryViewModel> ViewGet()
        {
            var command = $"[dbo].[SportCountry_Ids]";
            return executeSql(command).AsQueryable();
        }

        private IQueryable<SportCountryViewModel> executeSql(string commandText)
        {
            return _context.SportCountryViewModels.FromSqlRaw(commandText);
        }
    }
}
