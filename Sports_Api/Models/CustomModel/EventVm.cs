using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CustomModel
{
    public class EventVm
    {
        [Key]
        public int EventId { get; set; }
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public string EventName { get; set; }
        public DateTime EeventDate { get; set; }
    }
}
