using DietApp.Entities.Common;
using DietApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BL.Services
{
    public interface IUserDayMealFoodService
    {
        string AddDayMealFood(StructUserDayMealFood sUserDayMealFood);

        string RemoveUserFood(int id);


        string UpdateUserFood(StructUserDayMealFood sUserDayMealFood);

        ICollection<StructUserDayMealFood> ShowUserFoods(int id);
    }
}
