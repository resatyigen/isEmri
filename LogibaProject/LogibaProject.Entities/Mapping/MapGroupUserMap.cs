using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Entities.Mapping
{
    public class MapGroupUserMap:EntityTypeConfiguration<MapGroupUser>
    {
        public MapGroupUserMap()
        {
            this.HasKey(t => t.id);

            this.ToTable("MapGroupUser");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.UserId).HasColumnName("UserId");

            // Relationships
            this.HasRequired(t => t.Group)
                .WithMany(t => t.MapGroupUsers)
                .HasForeignKey(t => t.GroupId);

            this.HasRequired(t => t.User)
                .WithMany(t => t.MapGroupUsers)
                .HasForeignKey(t => t.UserId);

        }
    }
}
