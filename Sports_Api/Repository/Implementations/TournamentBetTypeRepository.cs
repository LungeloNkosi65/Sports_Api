using Microsoft.EntityFrameworkCore;
using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class TournamentBetTypeRepository:ITournamentBetTypeRepository
    {
        private HollywoodBetsRepDbContext _context;
        public TournamentBetTypeRepository(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }

        public void Add(TournamentBetType tournamentBetType)
        {
            _context.TournamentBetType.Add(tournamentBetType);
            _context.SaveChanges();
        }

        public void Delete(int? tbTid)
        {
            var dbRecord = Find(tbTid);
            _context.TournamentBetType.Remove(dbRecord);
            _context.SaveChanges();
        }

        public TournamentBetType Find(int? tbTid)
        {
            return _context.TournamentBetType.Find(tbTid);
        }

        public IQueryable<TournamentBetType> Get(int? tbTid)
        {
            return _context.TournamentBetType.Where(x=>x.TbTid==tbTid).AsQueryable();
        }

        public IQueryable<TournamentBetType> GetAll()
        {
            return _context.TournamentBetType.AsQueryable();
        }

        public IQueryable<TournamentBetTypeVm> GetAllVm()
        {
            string commandText = "[dbo].[TournamentBetType_Ids]";
            return ExecuteSql(commandText);
        }

        public void Update(TournamentBetType tournamentBetType)
        {
            _context.Entry(tournamentBetType);
            _context.SaveChanges();
        }
        private IQueryable<TournamentBetTypeVm>ExecuteSql(string commandText)
        {
            return _context.TournamentBetTypeVms.FromSqlRaw(commandText).AsQueryable();
        }
    }
}
