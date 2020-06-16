using Sports_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    interface IExotic
    {
        IEnumerable<Exotics> GetAll();
        Exotics Get(int id);
        Exotics Add(Exotics item);
        void Remove(int id);
        bool Update(Exotics item);
    }
}
