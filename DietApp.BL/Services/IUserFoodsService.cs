using DietApp.Entities.Common;
using DietApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BL.Services
{
    public interface IUserFoodsService
    {
        string AddUserFood(string foodName, decimal portion, Meal meal, DateTime dateTime, string photoPath);
    }
}
