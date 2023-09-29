using DietApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities.Concrete
{
    public class UserFood : IEntity
    {
        public int ID { get; set; }
        public string FoodName { get; set; }
        public int Calories { get; set; }

        #region Navigational Properties

        #region Category
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        #endregion

        #region UserDaysMealsFoods
        public ICollection<UserDayMealFood> UserDayMealFoods { get; set; }
        #endregion

        #region FoodDetails
        public int UserID { get; set; }
        public User User { get; set; }
        #endregion

        #endregion

        public UserFood()
        {
            UserDayMealFoods = new List<UserDayMealFood>();
        } 
    }
}
