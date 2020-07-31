using Microsoft.EntityFrameworkCore;
using Sports_Api.Models.CustomModel;
using Sports_Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository.Implementations
{
    public class SoccerCuponRepository : ISoccerCuponRepository
    {
        private readonly HollywoodBetsRepDbContext _context;

        public SoccerCuponRepository(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }
        public IQueryable<SoccerCupon> GetCupon()
        {
            string commandText = $"[dbo].[SoccerCupon] ";
            return ExecuteSql(commandText);
        }

        public IQueryable<SoccerCupon>ExecuteSql(string commandText)
        {
           return _context.SoccerCupons.FromSqlRaw($"{commandText}").AsQueryable();
        }
    }
}
