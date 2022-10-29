using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class FoodDetailMapping : EntityTypeConfiguration<FoodDetail>
    {
        public FoodDetailMapping()
        {
            this.ToTable("FoodDetails") // Tablo adı eklenecek!!!
              .HasKey<int>(x => x.FoodDetailID);

            this.HasRequired<Meal>(g => g.Meals)
                .WithMany(x => x.FoodDetails);
            this.HasRequired<User>(g => g.Users)
                .WithMany(x => x.FoodDetails);
            this.HasRequired<Food>(g => g.Foods)
                .WithMany(x => x.FoodDetails);


        }
    }
}
