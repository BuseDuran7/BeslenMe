using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class FoodMapping : EntityTypeConfiguration<Food>
    {
        public FoodMapping()
        {
            this.ToTable("Foods")
               .HasKey<int>(x => x.FoodID);

            this.Property(g => g.FoodName)
                .HasMaxLength(50)
                .IsRequired();
        }
       
    }
}
