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
    public class UserDayMealFoodRepository : GenericRepository<UserDayMealFood>
    {
        private DbSet<UserFood> DbSetUserFood;
        private DbSet<FoodPhoto> DbSetFoodPhoto;
        private DbSet<MealType> DbSetMealTypes;

        public UserDayMealFoodRepository(DbContext context) : base (context)
        {
            DbSetUserFood = context.Set<UserFood> ();
            DbSetFoodPhoto = context.Set<FoodPhoto> ();
        }

        public bool AddDayMealFood(int id, string foodName, decimal portion, string categoryName, decimal calories, string MealName, DateTime dateTime, string photoPath)
        {

            if (DbSetUserFood.Where(f => f.FoodName != foodName).Any())
            {
                FoodPhoto newPhoto = new();

                try
                {
                    var categoryID = DbSetUserFood.Include(c => c.Category).Where(c => c.Category.CategoryName == categoryName).Select(c => c.CategoryID).FirstOrDefault();

                    var newFood = new UserFood()
                    {
                        FoodName = foodName,
                        CategoryID = categoryID,
                        Calories = (int)calories

                    };

                    DbSetUserFood.Add(newFood);

                    var newUserDayMealFood = new UserDayMealFood();

                    if (photoPath != null)
                    {
                        if (DbSetFoodPhoto.Where(fd => fd.PhotoPath == photoPath).Any())
                        {
                            newUserDayMealFood.FoodPhotoID = DbSetFoodPhoto.Where(fd => fd.PhotoPath == photoPath).Select(fd => fd.ID).FirstOrDefault();
                        }
                        else
                        {
                            newPhoto.PhotoPath = photoPath;

                            DbSetFoodPhoto.Add(newPhoto);

                            newUserDayMealFood.FoodPhotoID = newPhoto.ID;
                        }
                    }

                    int mealID = DbSetMealTypes.Where(x=> x.MealName == MealName).Select(x => x.ID).FirstOrDefault();

                    newUserDayMealFood.Status = Status.Active;
                    newUserDayMealFood.MealTypeID = mealID;
                    newUserDayMealFood.DateTime = dateTime;
                    newUserDayMealFood.UserFoodID = newFood.ID;
                    newUserDayMealFood.Portion = portion;

                    Add(newUserDayMealFood);

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                FoodPhoto newPhoto = new();

                try
                {
                    var categoryID = DbSetUserFood.Include(c => c.Category).Where(c => c.Category.CategoryName == categoryName).Select(c => c.CategoryID).FirstOrDefault();

                    var newUserDayMealFood = new UserDayMealFood();

                    if (photoPath != null)
                    {
                        if (DbSetFoodPhoto.Where(fd => fd.PhotoPath == photoPath).Any())
                        {
                            newUserDayMealFood.FoodPhotoID = DbSetFoodPhoto.Where(fd => fd.PhotoPath == photoPath).Select(fd => fd.ID).FirstOrDefault();
                        }
                        else
                        {
                            newPhoto.PhotoPath = photoPath;

                            DbSetFoodPhoto.Add(newPhoto);

                            newUserDayMealFood.FoodPhotoID = newPhoto.ID;
                        }
                    }

                    var userFoodID = DbSetUserFood.Where(uf => uf.CategoryID == categoryID).Select(uf => uf.ID).FirstOrDefault();

                    int mealID = DbSetMealTypes.Where(x => x.MealName == MealName).Select(x => x.ID).FirstOrDefault();

                    newUserDayMealFood.Status = Status.Active;
                    newUserDayMealFood.MealTypeID = mealID;
                    newUserDayMealFood.DateTime = dateTime;
                    newUserDayMealFood.UserFoodID = userFoodID;
                    newUserDayMealFood.Portion = portion;

                    Add(newUserDayMealFood);

                    return true;
                }
                catch
                {
                    return false;
                }
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

        public bool UpdateUserFood(int id, string foodName, decimal portion, string mealTypeName, DateTime dateTime, string photoPath)
        {
            FoodPhoto currentPhoto;

            if(DbSetFoodPhoto.Where(f => f.PhotoPath == photoPath).Any())
            {
                currentPhoto = DbSetFoodPhoto.Where(f => f.PhotoPath == photoPath).First();
            }
            else
            {
                currentPhoto = new FoodPhoto()
                {
                    PhotoPath = photoPath,
                };
            }

            var currentFood = DbSetUserFood.Where(f => f.FoodName == foodName).FirstOrDefault();

            try
            {
                var oldData = DbSet.Where(uf => uf.ID == id).First();
                oldData.Status = Status.Passive;

                int mealID = DbSetMealTypes.Where(x => x.MealName == mealTypeName).Select(x => x.ID).FirstOrDefault();

                var newUserFood = new UserDayMealFood()
                {
                    UserFoodID = currentFood.ID,
                    //Meal = meal,
                    Portion = portion,
                    DateTime = dateTime,
                    FoodPhotoID = currentPhoto.ID,
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

        public IList<StructUserDayMealFood> ShowDayMealFoods(int id)
        {
            var currentList = DbSet.Include(uf => uf.UserFood).Where( uf => (uf.Status == Status.Active) && uf.UserFood.UserID == id).OrderBy(uf => uf.DateTime).Select(uf => new StructUserDayMealFood
            {

                ID = uf.ID,
                CategoryName = uf.UserFood.Category.CategoryName,
                FoodName = uf.UserFood.FoodName,
                Portion = uf.Portion,
                Calories = (uf.UserFood.Calories) * uf.Portion,
                DateTime = uf.DateTime

            }).ToList(); 
            return currentList;
        }

        //gün sonu raporu

        // kıyas raporları:

        //yemek çeşidi raporu
    }
}
