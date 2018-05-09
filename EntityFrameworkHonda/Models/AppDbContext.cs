using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFrameworkHonda.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("EntityFrameworkHonda") { }

        public virtual DbSet<Civic> Civics { get; set; }
    }
}