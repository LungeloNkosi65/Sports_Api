using Dapper;
using Microsoft.EntityFrameworkCore;
using Sports_Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class SportRepository : ISportRepository
    {
        private readonly HollywoodBetsRepDbContext _context;
        public SportRepository(HollywoodBetsRepDbContext hollywoodBetsRepDbContext)
        {
            _context = hollywoodBetsRepDbContext;
        }

        public void Add(SportsTree sportsTree)
        {
            _context.SportsTree.Add(sportsTree);
            _context.SaveChanges();
        }

        public void delete(int? sportId)
        {
            var dbRecord = Find(sportId);
            _context.SportsTree.Remove(dbRecord);
            _context.SaveChanges();
        }

        public SportsTree Find(int? id)
        {
            return _context.SportsTree.Find(id);
        }

        public IQueryable<SportsTree> Get()
        {
            //using (var connection = DatabaseService.sqlConnection())
            //{
            //    var results = connection.Query<SportsTree>("select  SportId,Name,Logo from SportsTree ");
            //    return results.AsQueryable();
            //}
            return _context.SportsTree;
        }

        public IQueryable<SportsTree> Get(int? id)
        {
            return _context.SportsTree.Where(x => x.SportId == id);
            
        }

        public void udate(SportsTree sportsTree)
        {
            _context.Entry(sportsTree).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
