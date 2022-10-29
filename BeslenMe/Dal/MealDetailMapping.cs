using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class MealDetailMapping : EntityTypeConfiguration<MealDetail>
    {
        public MealDetailMapping()
        {
            this.ToTable("MealDetails") // Tablo adı eklenecek!!!
               .HasKey<int>(x => x.MealDetailID);

            this.HasRequired<Meal>(g => g.Meals).WithMany(x => x.MealDetails);//.HasForeignKey(x => x.MealID);

            this.HasRequired<User>(g => g.Users).WithMany(x => x.MealDetails);//.HasForeignKey(x => x.User.UserID);

            //this.HasMany<Food>(f => f.Foods).WithMany(m => m.MealDetails).Map(md => { md.MapLeftKey("FoodID").MapRightKey("MealDetailID").ToTable("MealDetailIDFoodID"); });

        }
    }
}
