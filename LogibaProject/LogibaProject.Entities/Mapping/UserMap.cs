using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Entities.Mapping
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasKey(t => t.id);

            this.Property(t => t.FullName).HasMaxLength(250);
            this.Property(t => t.UserName).HasMaxLength(250);
            this.Property(t => t.Password).HasMaxLength(250);

            // Table & Column Mapping

            this.ToTable("Users");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
        }
    }
}
