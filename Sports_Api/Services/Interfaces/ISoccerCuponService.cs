using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services.Interfaces
{
   public interface ISoccerCuponService
    {
        public IQueryable<SoccerCupon> GetCupon();

    }
}
