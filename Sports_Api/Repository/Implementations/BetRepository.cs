using Microsoft.EntityFrameworkCore;
using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class BetRepository : IBetRepository
    {
        private readonly HollywoodBetsRepDbContext _context;
        public BetRepository(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }
        public void CancellBet(int? betId)
        {
            var dbRecord = Find(betId);
            dbRecord.Status = "Cancelled";
            _context.Entry(dbRecord).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public BetTbl Find(int? betId)
        {
            return _context.BetTbl.Find(betId);
        }

        public IQueryable<BetSlip> GetBets()
        {
            return _context.BetSlip.AsQueryable();
        }

        public IQueryable<BetTbl> GetBetEvents()
        {
            return _context.BetTbl.AsQueryable();
        }

       

        public void PlaceBet(SubmitedBet submitedBet)
        {
            
            _context.BetSlip.Add(submitedBet.BetSlip);
            _context.SaveChanges();

            for(int i=0; i < submitedBet.BetTbls.Length; i++)
            {
                //submitedBet.BetTbls[i].BetId = GetBetEvents().Count()-1+1;
                submitedBet.BetTbls[i].TicketNumber = Guid.NewGuid().ToString();
                submitedBet.BetTbls[i].Date = DateTime.Now.Date;
                _context.BetTbl.Add(submitedBet.BetTbls[i]);
                _context.SaveChanges();

            }
        }

        public IQueryable<BetTbl> RecentBets(string accountNumber)
        {
            //var resuts = _context.BetTbl.Where(x => x.a == accountNumber).AsQueryable();
            //return resuts;
            throw new NotImplementedException();
        }

        public IQueryable<RecentBetsVm> GetRecentBets(string userAccount)
        {
            string commandText = $"[dbo].[RecentBets] @account={userAccount}";
            return ExecuteSql(commandText);
        }

        private IQueryable<RecentBetsVm>ExecuteSql(string sqlStatement)
        {
            return _context.RecentBetsVms.FromSqlRaw($"{sqlStatement}").AsQueryable();
        }

        
    }
}
