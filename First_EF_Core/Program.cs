using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

// Source: https://docs.microsoft.com/en-us/ef/core/get-started/index?tabs=visual-studio#run-from-visual-studio

namespace First_EF_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                // Create
                Console.WriteLine("Inserting new products");
                db.Add(new Product {Maker = "Morten", Model = "GForceXWing", Type = "SomeType"});
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a product");
                var product = db.products.OrderBy(p => p.ProductId).First();
                
                // Update
                Console.WriteLine("Updating a product");
                product.Maker = "Viktor";
                db.SaveChanges();

                // Delete
                Console.WriteLine("Deleting a product");
                db.Remove(product);
                db.SaveChanges();
            }
        }
    }
}
