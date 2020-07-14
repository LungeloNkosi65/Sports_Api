using System;
using System.Collections.Generic;

namespace Sports_Api
{
    public partial class BonusTbl
    {
        public int BonusId { get; set; }
        public int Legs { get; set; }
        public decimal BonusPercent { get; set; }
    }
}
