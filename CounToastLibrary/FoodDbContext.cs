using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CounToastLibrary
{
    public class FoodDbContext : DbContext
    {
        public DbSet<Food> FoodSet { get; set; }
        string DataBasePath { get; set; }

        public FoodDbContext(string databaseFilename)
        {
            DataBasePath = databaseFilename;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Filename={DataBasePath}");
        }
    }
}
