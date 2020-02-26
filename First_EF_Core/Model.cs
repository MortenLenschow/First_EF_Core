using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

// Source: https://docs.microsoft.com/en-us/ef/core/get-started/index?tabs=visual-studio#run-from-visual-studio

namespace First_EF_Core
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=door.db");

        public DbSet<Product> products { get; set; }
    }

    public class Product
    {
        public Product() { }
        public int ProductId { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
    }
}
