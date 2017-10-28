namespace EFCodeFirst.Migrations
{
    using EFCodeFirst.Models;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirst.Data.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCodeFirst.Data.SalesContext context)
        {
            var banana = new Product("Chuoi", 100, 2.30M);
            var kiwi = new Product("Kiwi", 50, 3.45M);
            var orange = new Product("Orange", 80, 3.27M);
            var strawberry = new Product("Strawberry", 76, 5.47M);
            var papaya = new Product("Papaya", 30, 3.47M);
            var centerStore = new StoreLocation("Center Store");
            var eastStore = new StoreLocation("East Store");
            var westStore = new StoreLocation("West Store");
            var northStore = new StoreLocation("North Store");
            var southStore = new StoreLocation("South Store");
            var firstCustomer = new Customer("First", "A", "First@First.com");
            var secondCustomer = new Customer("Second", "b", "Second@Second.com");
            var thirdCustomer = new Customer("Third", "c", "Third@Third.com");
            var fourthCustomer = new Customer("Fourth", "d", "Fourth@Fourth.com");
            var fifthCustomer = new Customer("Fifth", "e", "Fifth@Fifth.com");
            if (context.Products.Count() == 0)
            {
                context.Products.AddRange(new[]
                  {
                    banana, kiwi, orange, strawberry, papaya
                });
                context.SaveChanges();

            }
            if (context.StoreLocations.Count() == 0)
            {
                context.StoreLocations.AddRange(new[]
                 {
                    centerStore, eastStore, westStore, northStore, southStore
                });
                context.SaveChanges();

            }
            if (context.Customers.Count() == 0)
            {
                context.Customers.AddRange(new[]
               {
                    firstCustomer, secondCustomer, thirdCustomer, fourthCustomer, fifthCustomer
                });
                context.SaveChanges();

            }
            if (context.Sales.Count() == 0)
            {
                firstCustomer.Sales.Add(new Sale(banana.Id, fifthCustomer.Id, centerStore.Id));
                firstCustomer.Sales.Add(new Sale(orange.Id, firstCustomer.Id, centerStore.Id));
                secondCustomer.Sales.Add(new Sale(banana.Id, secondCustomer.Id, eastStore.Id));
                secondCustomer.Sales.Add(new Sale(orange.Id, secondCustomer.Id, eastStore.Id));
                thirdCustomer.Sales.Add(new Sale(kiwi.Id, thirdCustomer.Id, westStore.Id));

                context.SaveChanges();
            }

        }
    }
}
