using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_to_many.Data
{
    using Many_to_many.Models;
   public class OneZeroDbcontext:DbContext
    {
        public OneZeroDbcontext() : base("Many")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
