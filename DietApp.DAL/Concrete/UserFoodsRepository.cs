using DietApp.Entities.Common;
using DietApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Concrete
{
    public class UserFoodsRepository : GenericRepository<UserFood>
    {
        private DbSet<Food> DbSetFood;
        private DbSet<FoodPhoto> DbSetPhoto;

        public UserFoodsRepository(DbContext context) : base (context)
        {
            DbSetFood = context.Set<Food> ();
            DbSetPhoto = context.Set<FoodPhoto> ();
        }

        public bool AddUserFood(string foodName, decimal portion, Meal meal, DateTime dateTime ,string photoPath)
        {
            try
            {
                var newPhoto = new FoodPhoto()
                {
                    PhotoPath = photoPath,
                };

                var currentFood = DbSetFood.Where(f => f.FoodName == foodName).FirstOrDefault();

                var newUserFood = new UserFood()
                {
                    FoodID = currentFood.ID,
                    Meal = meal,
                    Portion = portion,
                    DateTime = dateTime,
                    PhotoID = newPhoto.ID,
                    Status = Status.Active
                };

                Add(newUserFood);

                return true;
            }
            catch
            {
                return false;
            } 
        }

        public bool RemoveUserFood(int id)
        {
            try
            {
                var softDeletedData = Get(id);
                softDeletedData.Status = Status.Passive;
                return true;
            }
            catch
            {
                return false;
            } 
        }

        public bool UpdateUserFood(int id, string foodName, decimal portion, Meal meal, DateTime dateTime, string photoPath)
        {
            FoodPhoto currentPhoto;

            if(DbSetPhoto.Where(f => f.PhotoPath == photoPath).Any())
            {
                currentPhoto = DbSetPhoto.Where(f => f.PhotoPath == photoPath).First();
            }
            else
            {
                currentPhoto = new FoodPhoto()
                {
                    PhotoPath = photoPath,
                };
            }

            var currentFood = DbSetFood.Where(f => f.FoodName == foodName).FirstOrDefault();

            try
            {
                var oldData = DbSet.Where(uf => uf.ID == id).First();
                oldData.Status = Status.Passive;

                var newUserFood = new UserFood()
                {
                    FoodID = currentFood.ID,
                    Meal = meal,
                    Portion = portion,
                    DateTime = dateTime,
                    PhotoID = currentPhoto.ID,
                    Status = Status.Active
                };
                Add(newUserFood);
                return true;
            }
            catch
            {
                return false;
            }  
        }

        public ICollection ShowUserFoods(int id)
        {
            var currentList = DbSet.Include(uf => uf.Food).Where( uf => (uf.Status == Status.Active) && uf.UserID == id).OrderBy(uf => uf.DateTime).Select(uf => new
            {
                uf.ID,
                uf.Food.FoodName,
                uf.Meal,
                uf.Portion,
                uf.DateTime
            }).ToList(); 
            return currentList;
        }
    }
}
