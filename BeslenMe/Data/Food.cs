using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class Food
    {
        [Key]
        
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public string Amount { get; set; }
        public string Portion { get; set; }
        public double? Calorie { get; set; }

        public double? Protein   { get; set; }

        public double? Fat { get; set; }
        public string FoodUnit { get; set; }
        public double? Carbs{ get; set; }
        public string CalorieUnit { get; set; }
        public int CategoryID { get; set; }



        //Navigation Props
        public virtual Category Categories { get; set; }
        public virtual List<FoodDetail> FoodDetails { get; set; }

    }
}
