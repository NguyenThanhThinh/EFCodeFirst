using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_Zero.Data
{
    using One_to_Zero.Models;
   public class OneZeroDbcontext:DbContext
    {
        public OneZeroDbcontext() : base("OneZero")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
