using Microsoft.EntityFrameworkCore;
using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class SportTournamentRepository : ISportTournamentRepository
    {
        private readonly HollywoodBetsRepDbContext _context;
        public SportTournamentRepository(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }
        public void Add(SportsTournament sportsTournament)
        {
            _context.SportsTournament.Add(sportsTournament);
            _context.SaveChanges();
        }

        public void Delete(int? sportTourtnamentId)
        {
            var dbRecord = Find(sportTourtnamentId);
            _context.SportsTournament.Remove(dbRecord);
            _context.SaveChanges();
        }

        public SportsTournament Find(int? sportTourtnamentId)
        {
            return _context.SportsTournament.Find(sportTourtnamentId);
        }

        public IQueryable<SportsTournament> GetAll()
        {
           return _context.SportsTournament.AsQueryable();
        }

        public IQueryable<SportsTournamentVm> GetAllVm()
        {
            string commandText = $"[dbo].[SportTourname_Ids]";
            return ExecuteSql(commandText);
        }

        public IQueryable<SportsTournament> getSingleSportTournament(int? sportTourtnamentId)
        {
            return _context.SportsTournament.Where(x => x.SportTourtnamentId == sportTourtnamentId).AsQueryable();
        }

        public void Update(SportsTournament sportsTournament)
        {
            _context.Entry(sportsTournament).State = EntityState.Modified;
            _context.SaveChanges();
        }
        private IQueryable<SportsTournamentVm> ExecuteSql(string commandText)
        {
            return _context.SportsTournamentVms.FromSqlRaw(commandText).AsQueryable();
        }
    }
}
