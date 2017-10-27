using System.Data.Entity;

namespace EFCodeFirst.Data
{
    using EFCodeFirst.Models;
    public class SalesContext: DbContext
    {
        public SalesContext()
           : base("SalesContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<StoreLocation> StoreLocations { get; set; }

        public virtual DbSet<Sale> Sales { get; set; }
    }
}
