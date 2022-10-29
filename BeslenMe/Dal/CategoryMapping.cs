using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            this.ToTable("Categories") // Tablo adı eklenecek!!!
               .HasKey<int>(x => x.CategoryID);

            this.Property(g => g.CategoryName)
                .HasMaxLength(255)
                .IsRequired();

            this.HasMany<Food>(g => g.Foods)
                .WithRequired(x => x.Categories);
            //.HasForeignKey(x => x.FoodID);



        }
    }
}
