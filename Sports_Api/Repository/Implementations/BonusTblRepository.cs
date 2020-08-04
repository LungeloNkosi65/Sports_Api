using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.EntityFrameworkCore;
using Sports_Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository.Implementations
{
    public class BonusTblRepository : IBonusTblRepository
    {
        private readonly HollywoodBetsRepDbContext _context;

        public BonusTblRepository(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }

        public void Add(BonusTbl bonusTbl)
        {
            _context.BonusTbl.Add(bonusTbl);
            _context.SaveChanges();
        }

        public void delete(int? bonusId)
        {
             var dbRecord = Find(bonusId);
            _context.BonusTbl.Remove(dbRecord);
            _context.SaveChanges();
        }

        public BonusTbl Find(int? bonusId)
        {
           return _context.BonusTbl.Find(bonusId);
            
        }

        public IQueryable<BonusTbl> GetAll()
        {
            return _context.BonusTbl.AsQueryable();
        }

        public IQueryable<BonusTbl> GetSingle(int? bonusId)
        {
            string commandText = $"[dbo].[GetSIngleBonus]  @bonusId={bonusId}";
            return ExecuteSql(commandText).AsQueryable();
        }

        public void update(BonusTbl bonusTbl)
        {
            _context.Entry(bonusTbl).State = EntityState.Modified;
            _context.SaveChanges();
        }


        private IQueryable<BonusTbl>ExecuteSql(string commandText)
        {
            return _context.BonusTbl.FromSqlRaw(commandText).AsQueryable();
        }
    }
}
