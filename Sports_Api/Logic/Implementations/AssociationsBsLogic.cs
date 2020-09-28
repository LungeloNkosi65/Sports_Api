using Sports_Api.Logic.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Logic.Implementations
{
    public class AssociationsBsLogicL : IAssociationsBsLogic
    {
        private HollywoodBetsRepDbContext _context;

        public AssociationsBsLogicL(HollywoodBetsRepDbContext context)
        {
            _context = context;
        }

        public bool IsExistingBetTypeMarket(BetTypeMarket betTypeMarket)
        {
            var isExistRecord = _context.BetTypeMarket
                .Where(x => x.BetTypeId == betTypeMarket.BetTypeId && x.MarketId == betTypeMarket.MarketId);
            return isExistRecord == null;
        }

        public bool IsExistingSportCountry(SportCountry sportCountry)
        {
            var isExistRecord = _context.SportCountry
                .Where(x => x.SportId == sportCountry.SportId && x.CountryId == sportCountry.CountryId).ToList();
            return isExistRecord.Count == 0;
            
        }
    }
}
