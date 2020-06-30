using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Repository;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetTypesController : ControllerBase
    {
        private readonly IBetTypeRepository _betTypeRepository;
        public BetTypesController(IBetTypeRepository betTypeRepository)
        {
            _betTypeRepository = betTypeRepository;
        }
        [HttpGet("tournamentId")]
        [Route("BetTypeForTournament")]
        public IEnumerable<BetType> Get(int? tournamentId)
        {
            return _betTypeRepository.GetBetTypesForTournament(tournamentId);

        }
    }
}