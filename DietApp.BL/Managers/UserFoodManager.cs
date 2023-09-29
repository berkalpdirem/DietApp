using DietApp.BL.Services;
using DietApp.DAL.Concrete;
using DietApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BL.Managers
{
    public class UserFoodManager : BaseManager<UserFood>, IUserFoodService
    {
        public UserFoodManager(GenericRepository<UserFood> genericRepository) : base(genericRepository)
        {

        }
    }
 
}
