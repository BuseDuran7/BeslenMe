using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class User
    {
        public int UserID { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public DateTime BirhtDate { get; set; }
        public bool Gender { get; set; }
        public string User_E_Mail { get; set; }
        public string User_password { get; set; }

        public int Age { get; set; }
        public double MyProperty { get; set; }

        public double BasalMetabolism { get; set; }

        //public double BasalMetabolism
        //{
        //    get
        //    {
        //        return BasalMetabolism;
        //    }
        //    set
        //    {
        //        if (Gender == true) // Gender true ise erkek demek!
        //        {
        //            double maleBasalMetabolismRatio = 66.5 + (13.75 * Weight) + (5.03 * Height) - (6.75 * Age );
        //            BasalMetabolism = maleBasalMetabolismRatio;
        //        }
        //        else // Kadınlara özel formül!
        //        {
        //            double femaleBasalMetabolismRatio = 655.1 + (9.56 * Weight) + (1.85 * Height) - (4.68 * Age);
        //            BasalMetabolism = femaleBasalMetabolismRatio;
        //        }
        //    }
        //}

        public double OptimalCal { get; set; }

        //public double? OptimalCal
        //{
        //    get
        //    {
        //        return OptimalCal;
        //    }
        //    set
        //    {
        //        OptimalCal = BasalMetabolism * 1.35;
        //    }
        //}

        //Nav prop

        public virtual List<FoodDetail>FoodDetails { get; set; }

    }
}
