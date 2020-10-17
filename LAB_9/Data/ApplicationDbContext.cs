using System;
using System.Collections.Generic;
using System.Text;
using Lab11.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab11.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CustomerProduct>().HasKey(sc => new { sc.CustomerId, sc.ProductId , sc.Order_date });
            modelBuilder.Entity<CustomerProduct>()
            .Property(b => b.Order_date)
            .HasDefaultValueSql("CONVERT(date, GETDATE())");
        }

        //public DbSet<Customer> customers;
        //public DbSet<Product> products;
        //public DbSet<CustomerProduct> CustomerProducts;
        public DbSet<Lab11.Models.Customer> Customer { get; set; }
        public DbSet<Lab11.Models.CustomerProduct> CustomerProduct { get; set; }
        public DbSet<Lab11.Models.Product> Product { get; set; }

    }
}
