using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Sports_Api.Models.CRUD_Logic
{
    public class MarketCrudLogic
    {
        private static HollywoodBetsRepDbContext _context=new HollywoodBetsRepDbContext();

        public static void AddMake(Make make)
        {
            _context.Makes.Add(make);
            _context.SaveChanges();

        }

        public static void UpdateMake(Make make)
        {
            _context.Entry(make).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteMake(int? makeId)
        {
            var makeFromDb = _context.Makes.Where(x => x.MakeId == makeId).FirstOrDefault();
            _context.Makes.Remove(makeFromDb);
            _context.SaveChanges();

        }


        public static List<Make> GettAllMakes()
        {
            var results = _context.Makes.ToList();
            return results;
        }


        public static Model(int? c)
        {
            var results = _context.Makes.Find(makeId);
            _context.SaveChanges()
        }


    }
}
