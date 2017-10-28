using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_many.Data
{
    using One_to_many.Models;
    public class OneManyDbContext : DbContext
    {
        public OneManyDbContext() : base("OneMany")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
