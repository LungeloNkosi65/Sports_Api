using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public interface ISportRepository
    {
        IQueryable<SportsTree> Get();
        IQueryable<SportsTree> Get(int? id);
        SportsTree Find(int? id);
    }
}
