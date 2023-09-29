using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities.Common
{
    public struct StructDataGridMeal
    {

        public int UserID { get; set; }
        public string CategoryName { get; set; }
        public string FoodName { get; set; }
        public decimal Portion { get; set; }
        public decimal Calories { get; set; }
        public DateTime DateTime { get; set; }

    }
}
