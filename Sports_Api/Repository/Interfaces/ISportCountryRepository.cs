﻿using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
   public interface ISportCountryRepository
    {
        void Add(SportCountry sportCountry);
        void delete(int? sportCountryId);
        void Update(SportCountry sportCountry);
        IQueryable<SportCountry> Get();
        IQueryable<SportCountry> GetSingle(int? sportCountryId);
        IQueryable<SportCountryViewModel> ViewGet();
    }
}
