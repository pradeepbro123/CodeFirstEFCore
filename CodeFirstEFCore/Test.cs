using CodeFirstEFCore.DatabaseContext;
using CodeFirstEFCore.Entities;

namespace CodeFirstEFCore
{
    public class Test
    {
        public static void TestDB()
        {
            var context = new OnlineStoreDBContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            List<Customer> customers = new List<Customer>()
            {
                new Customer{Name="Pradeep", Email = "bro@youtube.com"},
                new Customer{Name="Pradeep2", Email = "bro@youtube.com"},
                new Customer{Name="Pradeep3", Email = "bro@youtube.com"}
            };

            context.Customers.AddRange(customers);

            List<Item> items = new List<Item>
            {
                new Item{Name = "item0", Quantity = 10, Price = 100 },
                new Item{Name = "item1", Quantity = 6, Price = 200 },
                new Item{Name = "item2", Quantity = 3, Price = 300 },
            };
            context.Items.AddRange(items);

            context.SaveChanges();
        }
    }
}
