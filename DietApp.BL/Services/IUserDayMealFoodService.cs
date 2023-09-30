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

        string DeleteDayMealFood(int id);


        string UpdateDayMealFood(StructUserDayMealFood sUserDayMealFood);

        List<StructDataGridMeal> ShowDayMealFoods(int id);
    }
}
