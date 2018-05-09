using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using EntityFrameworkHonda.Models;

namespace EntityFrameworkHonda.Services
{
    public class CivicRepository
    {
        AppDbContext _db = new AppDbContext();
        public bool Create(int year, string trim, int doors)
        {
            var civic = new Civic
            {
                Year = year,
                Trim = trim,
                Doors = doors
            };

            var newCivic = _db.Civics.Add(civic);
            _db.SaveChanges();

            return newCivic.Id > 0;
        }
    }
}