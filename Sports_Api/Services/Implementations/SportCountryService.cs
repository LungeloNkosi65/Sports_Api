using Sports_Api.Logic.interfaces;
using Sports_Api.Models.CustomModel;
using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class SportCountryService : ISportCountryService
    {
        private readonly ISportCountryRepository _sportCountry;
        private readonly IAssociationsBsLogic _associationsBsLogic;

        public SportCountryService(ISportCountryRepository sportCountry, IAssociationsBsLogic associationsBsLogic)
        {
            _sportCountry = sportCountry;
            _associationsBsLogic = associationsBsLogic;
        }
        public bool Add(SportCountry sportCountry)
        {
            if (_associationsBsLogic.IsExistingSportCountry(sportCountry)==false)
            {
                return false;
            }
            else
            {
                _sportCountry.Add(sportCountry);
                return true;
            }
        }

        public void delete(int? sportCountryId)
        {
            _sportCountry.delete(sportCountryId);
        }

        public IQueryable<SportCountry> Get()
        {
            return _sportCountry.Get();
        }

        public IQueryable<SportCountry> GetSingle(int? sportCountryId)
        {
              return _sportCountry.GetSingle(sportCountryId);
        }

        public void Update(SportCountry sportCountry)
        {
            _sportCountry.Update(sportCountry);
        }

        public IQueryable<SportCountryViewModel> ViewGet()
        {
            return _sportCountry.ViewGet();
        }
    }
}
