using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CustomModel
{
    public class SoccerCupon
    {
        [Key]
        public int OddId { get; set; }

        public int SportId { get; set; }
        public string SportName { get; set; }
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public int BetTypeId { get; set; }
        public string BetTypeName { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public decimal Odds { get; set; }

    }
}
