using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Methods
    {


      
       
            ///Formdan alınan bilgi eklenicek

            public static int getAge(DateTime birthDate)
            {
                var today = DateTime.Today;
                var age = today.Year - birthDate.Year;
                var monthDiff = today.Month - birthDate.Month;
                var dayDiff = today.Day - birthDate.Day;

                if (dayDiff < 0)
                {
                    monthDiff--;
                }
                if (monthDiff < 0)
                {
                    age--;
                }
                return age;
            }
       
    }
}
