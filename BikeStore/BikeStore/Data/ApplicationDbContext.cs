﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BikeStore.Models;

namespace BikeStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductTypes> ProductTypes { get; set; }

        public DbSet<Products> Products { get; set; }
        public DbSet<Stores> Stores{ get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<ProductsSelectForReservation> ProductsSelectForReservations { get; set; }
        
        public DbSet<ApplicationUser> ApplicationUser { get; set; }


    }
}
