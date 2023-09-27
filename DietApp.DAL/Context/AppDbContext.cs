using DietApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Context
{
    public class AppDbContext : DbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Food> Foods { get; set; }
        DbSet<FoodDetails> FoodDetails { get; set; }
        DbSet<User> User { get; set; }
        DbSet<UserFoods> UserDayMealsFoods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-F4M3HC0\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Initial Catalog=DietAppDb; Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>()
                .HasKey(c => c.ID);
            mb.Entity<Category>()
                .HasMany(c => c.Foods)
                .WithOne(f => f.Category)
                .HasForeignKey(f => f.CategoryID)
                .IsRequired();

            mb.Entity<Food>()
                .HasKey(f => f.ID);
            mb.Entity<Food>()
                .HasOne(f => f.FoodDetails)
                .WithOne(fd => fd.Food)
                .HasForeignKey<FoodDetails>(fd => fd.FoodID);
            mb.Entity<Food>()
                .HasMany(f => f.UserDayMealsFoods)
                .WithOne(um => um.Food)
                .HasForeignKey(um => um.FoodID);


            mb.Entity<FoodDetails>()
                .HasKey(fd => fd.ID);
            mb.Entity<FoodDetails>()
                .Property(fd => fd.ID)
                .HasColumnOrder(1);
            mb.Entity<FoodDetails>()
                .Property(fd => fd.FoodID)
                .HasColumnOrder(2);
            mb.Entity<FoodDetails>()
                .HasIndex(fd => fd.FoodID)
                .IsUnique();


            mb.Entity<User>()
                .HasKey(u => u.ID);
            mb.Entity<User>()
                .HasMany(u => u.UserDayMealsFoods)
                .WithOne(um => um.User)
                .HasForeignKey(um => um.UserID);

            mb.Entity<UserFoods>()
                .Property(c => c.ID)
                .HasColumnOrder(1);
            mb.Entity<UserFoods>()
                .Property(c => c.UserID)
                .HasColumnOrder(2);
            mb.Entity<UserFoods>()
                .Property(c => c.FoodID)
                .HasColumnOrder(3);
            mb.Entity<UserFoods>()
                .Property(c => c.Meal)
                .HasColumnOrder(4);
            mb.Entity<UserFoods>()
                .Property(c => c.Portion)
                .HasPrecision(2, 1);
        }
    }
}
