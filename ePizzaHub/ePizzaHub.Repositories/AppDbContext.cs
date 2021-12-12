﻿using ePizzaHub.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ePizzaHub.Repositories
{
    public class AppDbContext:IdentityDbContext<User,Role,int>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=DESKTOP-CI5DFBR; initial catalog=ePizzaHubSite;integrated security=True;");

                //optionsBuilder.UseSqlServer(@"data source=Shailendra\SqlExpress; initial catalog=ePizzaHubSite;persist security info=True;user id=sa;password=dotnettricks;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
