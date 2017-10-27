
using System;

namespace EFCodeFirst
{
    using EFCodeFirst.Data;
    class Program
    {
        public static void Main()
        {
            using(var context=new SalesContext())
            {
                CustomesName(context);
                Sales(context);
            }
         
            Console.ReadKey();
        }

        private static void CustomesName(SalesContext context)
        {
            foreach (var person in context.Customers)
            {
                Console.WriteLine($"{person.FirstName} is {person.Age} yaers old");
            }
        }

        private static void Sales(SalesContext context)
            => ProductsMigration(context);

        private static void ProductsMigration(SalesContext context)
        {

            foreach (var sale in context.Sales
                .Include("Product")
                .Include("Customer")
                .Include("StoreLocation"))
            {
                Console.WriteLine($"{sale.Date.ToLocalTime()} - " +
                    $"{sale.StoreLocation.LocationName} sold " +
                    $"{sale.Product.Name} ({sale.Product.Description}) to " +
                    $"{sale.Customer.Email}");
            }
        }
    }
}
