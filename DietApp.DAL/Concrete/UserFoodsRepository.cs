using DietApp.Entities.Common;
using DietApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Concrete
{
    public class UserFoodsRepository : GenericRepository<UserFoods>
    {
        public UserFoodsRepository(DbContext context) : base (context)
        {

        }

        public string AddFood(string foodName, decimal portion, Meal meal, DateTime dateTime ,string photoPath)
        {
            return "";
        }

    }
}
