using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class BeslenMeContext : DbContext
    {
        public BeslenMeContext()
        {
            Database.Connection.ConnectionString = @"Server=BUSE\MSSQLSERVER2019;Database=BeslenMeDBLastVersion;Uid=sa;Pwd=123;";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new FoodDetailMapping());
            

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FoodDetail> FoodDetails { get; set; }

    }
}
