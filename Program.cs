using EF_Task22.contex;
using EF_Task22.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EF_Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplecationDbContex dbcontex= new ApplecationDbContex();
           /* product p=new product() {Name="Laptop",Price=1000 };
        dbcontex.products.Add(p);
            dbcontex.products.Add(new product() { Name = "Apple watch",Price = 5000 });
            dbcontex.products.Add(new product() { Name = "Jacket", Price = 100 });


            Order o = new Order() { Address = "Tulkarm", CreatedAt = new DateTime(2023, 8, 16, 20, 38, 0) };
            Order o2 = new Order() { Address = "Jenin", CreatedAt = DateTime.Parse("2022-05-19 7:40:00") };
            Order o3 = new Order { Address = "Ramallah", CreatedAt = new DateTime(2024, 10, 13, 2, 17, 4) };


            dbcontex.orders.Add(o);
            dbcontex.orders.Add(o2);
            dbcontex.orders.Add(o3);*/
            dbcontex.SaveChanges();
            // Get Products

            Console.WriteLine("Products : ");
            var products = dbcontex.products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }


            // Get Orders
            Console.WriteLine("Orders : ");
            var orders = dbcontex.orders.ToList();
            foreach (var order in orders)
            {
                Console.WriteLine($"ID: {order.Id}, Address: {order.Address}, CreatedAt: {order.CreatedAt}");
            }
            var productsToUpdate = dbcontex.products.Where(p => p.Id == 1).FirstOrDefault();
            if (productsToUpdate != null)
            {
                productsToUpdate.Name = "Laptop";
                dbcontex.SaveChanges();
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            dbcontex.SaveChanges();


            // Update Order CreatedAt
            var orderToUpdate = dbcontex.orders.FirstOrDefault(o => o.Id == 1);
            if (orderToUpdate != null)
            {
                orderToUpdate.CreatedAt = new DateTime(2023, 12, 31, 23, 59, 59);
                dbcontex.SaveChanges();
            }
            else
            {
                Console.WriteLine("Order not found.");
            }

            dbcontex.SaveChanges();




            //remove product with id 2
            dbcontex.Remove(dbcontex.products.First(p => p.Id == 2));

            //remove order with id 3
            dbcontex.Remove(dbcontex.orders.First(p => p.Id == 3));


            dbcontex.SaveChanges();






        }
    }
}
