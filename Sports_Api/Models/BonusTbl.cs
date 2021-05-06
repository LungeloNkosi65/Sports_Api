using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class BonusTbl
    {
        [Key]
        public int BonusId { get; set; }
        public int Legs { get; set; }
        public decimal BonusPercent { get; set; }
    }
}
