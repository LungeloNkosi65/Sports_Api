using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models
{
    public class BetTypeMarket
    {
        public int Id { get; set; }
        public int BetTypeId { get; set; }
        public List<int> Markets { get; set; }
        public BetTypeMarket(int id,int betTypeId, List<int>markets)
        {
            Id = id;
            BetTypeId = betTypeId;
            Markets = markets;
        }
    }
}
