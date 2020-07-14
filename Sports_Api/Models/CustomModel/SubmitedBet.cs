using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CustomModel
{
    public class SubmitedBet
    {
        public BetSlip BetSlip { get; set; }
        public List<BetTbl> BetTbls { get; set; }
    }
}
