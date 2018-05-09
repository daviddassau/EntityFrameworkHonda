using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkHonda.Models
{
    public class Civic
    {
        public virtual int Id { get; set; }
        public virtual int Year { get; set; }
        public virtual string Trim { get; set; }
        public virtual int Doors { get; set; }
    }
}