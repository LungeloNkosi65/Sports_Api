using Dapper;
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
        public SportsTree Find(int? id)
        {
            return _context.SportsTree.Find(id);
        }

        public IQueryable<SportsTree> Get()
        {
            using (var connection = DatabaseService.sqlConnection())
            {
                var results = connection.Query<SportsTree>("select  SportId,Name,Logo from SportsTree ");
                return results.AsQueryable();
            }
            //return _context.SportsTree;
        }

        public IQueryable<SportsTree> Get(int? id)
        {
            try
            {
                return _context.SportsTree.Where(x => x.SportId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
