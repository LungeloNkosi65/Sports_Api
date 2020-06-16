using Sports_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
    public class ExoticsRepository : IExotic
    {
        public List<Exotics> AllExotics = new List<Exotics>();
        public Exotics Add(Exotics item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.ExoticId++;
            AllExotics.Add(item);
            return item;
        }

        public Exotics Get(int id)
        {
            return AllExotics.Where(x=>x.ExoticId==id).FirstOrDefault();
        }

        public IEnumerable<Exotics> GetAll()
        {
            return AllExotics;
        }

        public void Remove(int id)
        {
            var getRecord = AllExotics.RemoveAll(x => x.ExoticId == id);
        }

        public bool Update(Exotics item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = AllExotics.FindIndex(x => x.ExoticId == item.ExoticId);
            if (index == -1)
            {
                return false;
            }
            AllExotics.RemoveAt(index);
            AllExotics.Add(item);
            return true;
        }
    }
}
