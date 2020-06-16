using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class Exotics
    {
        [Key]
        public int ExoticId { get; set; }
        public string  Name { get; set; }
        public string BetType { get; set; }
    }
}
