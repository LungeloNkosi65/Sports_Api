using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CustomModel
{
    public class TournamentBetTypeVm
    {
        [Key]
        public int TbTid { get; set; }
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public int BetTypeId { get; set; }
        public string BetTypeName { get; set; }
    }
}
