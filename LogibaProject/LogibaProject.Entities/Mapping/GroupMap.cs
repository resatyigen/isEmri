using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Entities.Mapping
{
    public class GroupMap:EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            this.HasKey(t => t.id);
            this.ToTable("Groups");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name)
                .HasMaxLength(200)
                .HasColumnName("Name");
        }
    }
}
