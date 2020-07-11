using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Services
{
    public interface ISportService
    {
        IQueryable<SportsTree> Get();
        IQueryable<SportsTree> Get(int? id);
        SportsTree Find(int? id);
        void Add(SportsTree sportsTree);

        void update(SportsTree sportsTree);
        void delete(int? sportId);

    }
}
