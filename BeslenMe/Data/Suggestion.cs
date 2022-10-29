using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Suggestion
    {

        public int SuggestionID { get; set; }//öneri ID

        public int Priority { get; set; }//Öneri önemi
        public string Description { get; set; }//Öneri tanımı

        //Nav Prop

        public virtual List<User> Users { get; set; }
    }
}
