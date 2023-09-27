using DietApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities.Concrete
{
    public class Food : IEntity
    {
        public int ID { get; set; }
        public string FoodName { get; set; }

        #region Navigational Properties

        #region Category
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        #endregion

        #region FoodDetails
        public FoodDetails FoodDetails { get; set; }
        #endregion

        #region UserDayMealsFoods
        public ICollection<UserFoods> UserDayMealsFoods { get; set; }
        #endregion

        #endregion

        public Food()
        {
            UserDayMealsFoods = new List<UserFoods>();
        }
    }
}
