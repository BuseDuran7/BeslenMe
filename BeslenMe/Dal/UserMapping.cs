using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dal
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        //public UserMapping()
        //{
        //    this.HasKey<int>(x => x.UserID);

        //    this.HasRequired(x => x.UserEntranceInfos);
        //}
    }
}
