﻿using FoodService.Services.ShoppingCartAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodService.Services.ShoppingCartAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<CartDetails> CartDetails { get; set; }

        public DbSet<CartHeader> CartHeader { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}