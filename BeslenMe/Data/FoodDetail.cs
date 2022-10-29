using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class FoodDetail
    {

        public int FoodDetailID { get; set; }
        //[ForeignKey("Food")]
        //public string FoodName { get; set; } // Furkanın eseri...
        public int UserID { get; set; }
        public int FoodID { get; set; }
        public int MealID { get; set; }
        public int Quantity { get; set; }
        public double Calorie { get; set; }
        public double TotalCalorie { get; set; }

        public double Protein { get; set; }

        public double Fat { get; set; }
        public double Carbs { get; set; }

        public DateTime EatenDate { get; set; }

        // NAV
        public virtual User Users { get; set; }
        public virtual Food Foods { get; set; }
        public virtual Meal Meals { get; set; }



       

    }
}
