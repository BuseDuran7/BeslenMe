using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class Meal
    {

        public int MealID { get; set; }
        public string MealName { get; set; }


        //Nav prop

        public virtual List<FoodDetail> FoodDetails { get; set; }

        public override string ToString()
        {
            return MealName;
        }
    }
}
