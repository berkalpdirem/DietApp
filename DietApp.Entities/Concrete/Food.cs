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
        public string ProductName { get; set; }

        #region Navigational Properties
        public int CategoryID { get; set; }
        public Category Category { get; set; } 
        #endregion
    }
}
