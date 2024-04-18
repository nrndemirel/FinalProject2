﻿using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    //Context: Db tablolari ile proje classlarini bagliyoruz.
    public class NorthWindContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(LocalDB)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

    }
}
