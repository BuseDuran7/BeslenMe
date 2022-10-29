using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class MealMapping : EntityTypeConfiguration<Meal>
    {
        public MealMapping()
        {
            this.ToTable("Meals") // Tablo adı eklenecek!!!
              .HasKey<int>(x => x.MealID);

            this.Property(g => g.MealName)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
