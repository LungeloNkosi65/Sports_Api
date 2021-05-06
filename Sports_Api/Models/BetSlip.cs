using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_Api
{
    public partial class BetSlip
    {
        public BetSlip()
        {
            BetTbl = new HashSet<BetTbl>();
        }

        [Key]
        public int BetSlipId { get; set; }
        public decimal StakeAmount { get; set; }
        public decimal Odds { get; set; }
        public decimal Payout { get; set; }
        public string UserAccount { get; set; }

        public virtual ICollection<BetTbl> BetTbl { get; set; }
    }
}
