using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CustomModel
{
    public class BetTypeMarketVm
    {
        [Key]
        public int BetTypeMarketId { get; set; }
        public string BetTypeMarketCode { get; set; }
        public int BetTypeId { get; set; }
        public string BetTypeName { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; }
    }
}
