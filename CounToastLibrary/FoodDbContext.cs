using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Food>().HasData(
                new Food
                {
                    Id = 1,
                    Name = "Kiwi",
                    Price = 0.5,
                    Quantity = 1,
                    ImageURL = "https://i.skyrock.net/2501/91542501/pics/3263953484_1_3_GF1CwvMY.jpg"
                },
                new Food
                {
                    Id = 2,
                    Name = "Pasta",
                    Price = 2.5,
                    Quantity = 2,
                    ImageURL = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/1._different_types_of_pasta-21a5324.jpg?quality=90&resize=768%2C574"
                },
                new Food
                {
                    Id = 3,
                    Name = "Pasta",
                    Price = 0.78,
                    Quantity = 1,
                    ImageURL = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/1._different_types_of_pasta-21a5324.jpg?quality=90&resize=768%2C574"
                },
                new Food
                {
                    Id = 4,
                    Name = "Zucchini",
                    Price = 3.99,
                    Quantity = 8,
                    ImageURL = "https://www.jessicagavin.com/wp-content/uploads/2018/05/zucchini-2-1200.jpg"
                }
            );
        }
    }
}
