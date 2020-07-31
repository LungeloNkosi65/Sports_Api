using Sports_Api.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository.Interfaces
{
    public interface ISoccerCuponRepository
    {
      public IQueryable<SoccerCupon> GetCupon();
    }
}
