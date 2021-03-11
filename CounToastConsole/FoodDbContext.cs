using CounToastLibrary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounToastConsole
{
    class FoodDbContext : DbContext
    {
        public DbSet<Food> FoodSet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dbFood.db");
        }
    }
}
