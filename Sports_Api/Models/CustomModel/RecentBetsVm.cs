using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CustomModel
{
    public class RecentBetsVm
    {
        [Key]
        public int BetSlipId { get; set; }
        public int BetId { get; set; }
        public string UserAccount { get; set; }
        public DateTime Date { get; set; }
        public string EventName { get; set; }
        public string TournamentName { get; set; }
        public string BetType { get; set; }
        public string  PunterChoice { get; set; }
        public decimal Odds { get; set; }
        public decimal Payout { get; set; }
        public string Status { get; set; }
    }
}
