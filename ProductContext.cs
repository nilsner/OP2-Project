using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace OP2_Project.Data
{
    public class ProdductContext : DbContext
    {
        public ProdductContext(DbContextOptions<ProdductContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        //public object Book { get; internal set; }

        //public DbSet<Book> Books { get; set; }
        //public DbSet<Author> Authors { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderLine> orderLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           //modelBuilder.Entity<Author>().HasMany(d => d.Books).WithOne(e => e.Author);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(GetCustomers());
            modelBuilder.Entity<Product>().HasData(GetProducts());
            modelBuilder.Entity<Order>().HasData(GetOrders());
            modelBuilder.Entity<OrderLine>().HasData(GetOrderLines());
        }

        private List<Product> GetProducts()
        {
            return new List<Product>{
            new Product { Id = 1, Name = "Cake", Price = 12.46, Stock = 10, Description ="The cake is a lie" }, new Product { Id = 2, Name = "A blue pen", Price =
            5.99, Stock = 50, Description ="It’s a blue pen.." },
            };
        }

        private List<Order> GetOrders()
        {
            return new List<Order>{
                new Order { Id = 991, CustomerId=GetCustomers()[0].Id, DeliveryAdress = "Hamngatan 3", Dispatched = false, OrderDate = DateTime.Now.Date, PaymentCompleted = false }
            };
        }

        private List<OrderLine> GetOrderLines()
        {
            return new List<OrderLine>{
            new OrderLine { Id = 1234, Quantity = 3, ProductId=GetProducts()[0].Id, OrderId=GetOrders()[0].Id }
            };
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>{
                new Customer { Id=901204, Name="Ano Nym", Phone="0705555555", Email="ano@gmail.com"},
                new Customer { Id=880417, Name="Test Testsson", Phone="0704444444", Email="t.test@outlook.com"}
            };
        }
    }
}
