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
        DbSet<User> Users { get; set; }
        DbSet<UserFood> UserFoods { get; set; }
        DbSet<UserDayMealFood> UserDayMealFoods { get; set; }
        DbSet<FoodPhoto> FoodPhotos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-F4M3HC0\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Initial Catalog=DietAppDb; Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>()
                .HasKey(c => c.ID);
            mb.Entity<Category>()
                .HasMany(c => c.UserFoods)
                .WithOne(f => f.Category)
                .HasForeignKey(f => f.CategoryID)
                .IsRequired();


            mb.Entity<UserFood>()
                .HasKey(f => f.ID);
            mb.Entity<UserFood>()
                .HasMany(uf => uf.UserDayMealFoods)
                .WithOne(udmf => udmf.UserFood)
                .HasForeignKey(udmf => udmf.UserFoodID);


            mb.Entity<User>()
                .HasKey(u => u.ID);
            mb.Entity<User>()
                .HasMany(u => u.UserDayMealFoods)
                .WithOne(um => um.User)
                .HasForeignKey(um => um.UserID);
            mb.Entity<User>()
                .HasMany(u => u.UserFoods)
                .WithOne(um => um.User)
                .HasForeignKey(um => um.UserID);


            mb.Entity<UserDayMealFood>()
                .HasKey(uf => uf.ID);
            mb.Entity<UserDayMealFood>()
                .Property(uf => uf.ID)
                .HasColumnOrder(1);
            mb.Entity<UserDayMealFood>()
                .Property(uf => uf.UserID)
                .HasColumnOrder(2);
            mb.Entity<UserDayMealFood>()
                .Property(uf => uf.UserFoodID)
                .HasColumnOrder(3);
            mb.Entity<UserDayMealFood>()
                .Property(uf => uf.Meal)
                .HasColumnOrder(4);
            mb.Entity<UserDayMealFood>()
                .Property(uf => uf.Portion)
                .HasPrecision(2, 1);


            mb.Entity<FoodPhoto>()
                .HasKey(fd => fd.ID);
            mb.Entity<FoodPhoto>()
                .HasMany(fd => fd.UserDayMealFoods)
                .WithOne(uf => uf.FoodPhoto)
                .HasForeignKey(uf => uf.FoodPhotoID)
                .IsRequired(false);
        }
    }
}
