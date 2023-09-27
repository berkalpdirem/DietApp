using DietApp.BL.Services;
using DietApp.DAL.Concrete;
using DietApp.Entities.Common;
using DietApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BL.Managers
{
    public class UserFoodsManager : BaseManager<UserFoods>, IUserFoodsService
    {
        protected UserFoodsRepository _userFoodsRepository;

        public UserFoodsManager(UserFoodsRepository userFoodsRepository , GenericRepository<UserFoods> genericRepository) : base(genericRepository)
        {
            _userFoodsRepository = userFoodsRepository;
        }

        public string AddFood(string foodName, decimal portion, Meal meal, DateTime dateTime, string photoPath)
        {
            return _userFoodsRepository.AddFood(foodName, portion, meal,  dateTime, photoPath);
        }
    }
}
