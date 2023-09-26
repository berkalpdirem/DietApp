using DietApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities.Concrete
{
    public class FoodDetails : IEntity
    {
        public int ID { get; set; }
        public int Calories { get; set; }

        #region Navigational Details
        
        #region Food
        
        public Food Food { get; set; }
        public int FoodID { get; set; }

        #endregion

        #endregion
    }
}
