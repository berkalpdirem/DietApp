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
    public class UserFoodsManager : BaseManager<UserFood>, IUserFoodsService
    {
        protected UserFoodsRepository _userFoodsRepository;

        public UserFoodsManager(UserFoodsRepository userFoodsRepository , GenericRepository<UserFood> genericRepository) : base(genericRepository)
        {
            _userFoodsRepository = userFoodsRepository;
        }

        public string AddUserFood(string foodName, decimal portion, Meal meal, DateTime dateTime, string photoPath)
        {
             if(_userFoodsRepository.AddUserFood(foodName, portion, meal,  dateTime, photoPath))
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
            if (_userFoodsRepository.RemoveUserFood(id))
            {
                return "Öğün içeriği silindi.";
            }
            else
            {
                return "Öğün içeriği silinemedi.";
            }
        }

        public string UpdateUserFood(int id, string foodName, decimal portion, Meal meal, DateTime dateTime, string photoPath)
        {
            if(_userFoodsRepository.UpdateUserFood(id, foodName, portion, meal, dateTime, photoPath))
            {
                return "Öğün içeriği güncellendi.";
            }
            else
            {
                return "Öğün içeriği güncellenemedi.";
            }
        }

        public ICollection ShowUserFoods(int id)
        {
            return _userFoodsRepository.ShowUserFoods(id);
        }
    }
}
