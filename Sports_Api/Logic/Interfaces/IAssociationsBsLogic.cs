using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Logic.interfaces
{
   public interface IAssociationsBsLogic
    {
        bool IsExistingSportCountry(SportCountry sportCountry);
        bool IsExistingBetTypeMarket(BetTypeMarket betTypeMarket);
    }
}
