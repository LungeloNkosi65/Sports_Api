using Sports_Api.Models.CustomModel;
using Sports_Api.Repository.Interfaces;
using Sports_Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services.Implementations
{
    public class SoccerCuponService : ISoccerCuponService
    {
        private readonly ISoccerCuponRepository _soccerCuponRepository; 
        public IQueryable<SoccerCupon> GetCupon()
        {
            return _soccerCuponRepository.GetCupon();
        }
    }
}
