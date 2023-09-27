using DietApp.Entities.Abstract;
using DietApp.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities.Concrete
{
    public class UserFoods : IEntity
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public Meal Meal { get; set; }
        public decimal Portion { get; set; }

        #region Navigational Properties

        #region User
        public int UserID { get; set; }
        public User User { get; set; }
        #endregion

        #region Food
        public int FoodID { get; set; }
        public Food Food { get; set; }
        #endregion 

        #endregion

    }
}
