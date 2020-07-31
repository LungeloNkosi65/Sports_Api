using Sports_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public class SportService : ISportService
    {
        private readonly ISportRepository _sportRepository;

        public SportService(ISportRepository sportRepository)
        {
            _sportRepository = sportRepository;
        }

        public void Add(SportsTree sportsTree)
        {
             _sportRepository.Add(sportsTree);
        }

        public void delete(int? sportId)
        {
            _sportRepository.delete(sportId);
        }

        public SportsTree Find(int? id)
        {
            return _sportRepository.Find(id);
        }

        public IQueryable<SportsTree> Get()
        {
            return _sportRepository.Get();
        }

        public IQueryable<SportsTree> Get(int? id)
        {
            return _sportRepository.Get(id);
        }

        public void update(SportsTree sportsTree)
        {
            _sportRepository.udate(sportsTree);
        }
    }
}
