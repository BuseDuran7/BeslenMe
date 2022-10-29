using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Data
{
    public class Category
    {

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
        public double? Score { get; set; }

        public string PicturePath { get; set; }//Resimin  Dosya yolu

        //  [Collumn Name]
        // public string MyProperty { get; set; }//Veritabanı tarafında image diye bir veri tipi var uydurmak gerekebilir


        //Nav prop

        public virtual List<Food> Foods { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
