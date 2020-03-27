using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class BetTyp
    {
        public int BetTypId { get; set; }
        public string BetTypeName { get; set; } 
        public BetTyp(int betTypeId, string betTypeName)
        {
            BetTypId = betTypeId;
            BetTypeName = betTypeName;
        }
    }
}
