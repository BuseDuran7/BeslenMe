using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MealDetail
    {
        public int MealDetailID { get; set; }
        public DateTime MealDetailDate { get; set; }
        //public Meal Meal { get; set; }
        //public User User { get; set; }
        //public Food Food { get; set; }

        // Nav Prop
        public virtual Meal Meals { get; set; }
        public virtual User Users { get; set; }
    }
}
