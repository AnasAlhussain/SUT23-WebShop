using SUT23_WebShop.Data;
using SUT23_WebShop.Models;

namespace SUT23_WebShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using WebShopDbContext context = new WebShopDbContext();


            //Product iphone15 = new Product()
            //{
            //    ProductName = "Iphone 15 pro Max",
            //    Price = 12999.9M
            //};
            //Product iphone14 = new Product()
            //{
            //    ProductName = "Iphone 14 pro ",
            //    Price = 10999.9M
            //};
            //Product iphone11 = new Product()
            //{
            //    ProductName = "Iphone 11  Max",
            //    Price = 8000.9M
            //};

            //context.Products.Add(iphone15);
            //context.Products.Add(iphone14);
            //context.Products.Add(iphone11);

            //Product samsung21 = new Product()
            //{
            //     ProductName = "Samsung S21 Ultra ",
            //      Price = 7000.0M
            //};
            //Product samsung24 = new Product()
            //{
            //    ProductName = "Samsung S24 Ultra ",
            //    Price = 18000.9M
            //};
            //context.Products.Add(samsung24);
            //context.Products.Add(samsung21);


            //context.SaveChanges();


            // Read from DB 
            //Fluent API Syntax 

            //var products =  context.Products.
            //      Where(p => p.Price >= 10000.00m)
            //      .OrderBy(p => p.ProductName);

            //  foreach(Product p in products)
            //  {
            //      Console.WriteLine($"ID : {p.ProductId}");
            //      Console.WriteLine($"Name : {p.ProductName}");
            //      Console.WriteLine($"Price : {p.Price}");
            //      Console.WriteLine(new string('-',20));
            //  }

            //  Console.WriteLine("***************************************");
            //  //Reading LINQ syntax 

            //  var products2LINQ = from p in context.Products
            //                      where p.Price >= 10000.00m
            //                      orderby p.ProductName
            //                      select p;

            //  foreach (Product item in products2LINQ)
            //  {
            //      Console.WriteLine($"ID : {item.ProductId}");
            //      Console.WriteLine($"Name : {item.ProductName}");
            //      Console.WriteLine($"Price : {item.Price}");
            //      Console.WriteLine(new string('-', 20));
            //  }


            //Edit record

            //var result = context.Products.
            //    Where(p => p.ProductName == "Samsung S24 Ultra").FirstOrDefault();
            //if( result is Product)
            //{
            //    result.Price = 20000.00m;
            //}
            //context.SaveChanges();


            //Delete Record

            //var result = context.Products
            //    .Where(p => p.ProductName == "Samsung S24 Ultra")
            //    .FirstOrDefault();
            //if (result is Product)
            //{
            //    context.Remove(result);
            //}
            //context.SaveChanges();


        }
    }
}
