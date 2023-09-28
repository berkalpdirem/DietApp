using DietApp.BL.Services;
using DietApp.DAL.Concrete;
using DietApp.Entities.Common;
using DietApp.Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BL.Managers
{
    public class UserDayMealFoodManager : BaseManager<UserFood>, IUserDayMealFoodService
    {
        protected UserDayMealFoodRepository _userDayMealFoodRepository;

        public UserDayMealFoodManager(UserDayMealFoodRepository userDayMealFoodRepository , GenericRepository<UserFood> genericRepository) : base(genericRepository)
        {
            _userDayMealFoodRepository = userDayMealFoodRepository;
        }

        public string AddDayMealFood(StructUserDayMealFood sUserDayMealFood)
        {
            if (_userDayMealFoodRepository.AddDayMealFood(sUserDayMealFood.UserID, sUserDayMealFood.FoodName,
             sUserDayMealFood.Portion, sUserDayMealFood.CategoryName, sUserDayMealFood.Calories, sUserDayMealFood.Meal, sUserDayMealFood.DateTime, sUserDayMealFood.PhotoPath))
            {
                return "Öğün içeriği eklendi.";
            }
             else 
            { 
                return "Öğün içeriği eklenemedi."; 
            }
        }

        public string RemoveUserFood(int id)
        {
            if (_userDayMealFoodRepository.RemoveUserFood(id))
            {
                return "Öğün içeriği silindi.";
            }
            else
            {
                return "Öğün içeriği silinemedi.";
            }
        }

        public string UpdateUserFood(StructUserDayMealFood sUserDayMealFood)
        {
            if(_userDayMealFoodRepository.UpdateUserFood(sUserDayMealFood.ID, sUserDayMealFood.FoodName, sUserDayMealFood.Portion, sUserDayMealFood.Meal, sUserDayMealFood.DateTime, sUserDayMealFood.PhotoPath))
            {
                return "Öğün içeriği güncellendi.";
            }
            else
            {
                return "Öğün içeriği güncellenemedi.";
            }
        }

        public ICollection<StructUserDayMealFood> ShowUserFoods(int id)
        {
            return _userDayMealFoodRepository.ShowDayMealFoods(id);
        }
    }
}
