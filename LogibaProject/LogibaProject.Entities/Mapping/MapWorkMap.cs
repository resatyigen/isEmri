using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Entities.Mapping
{
    public class MapWorkMap:EntityTypeConfiguration<MapWork>
    {
        public MapWorkMap()
        {
            this.HasKey(t => t.id);

            this.ToTable("MapWork");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.WorkId).HasColumnName("WorkId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");

            this.Property(t => t.UserId)
                .IsOptional();

            this.Property(t => t.GroupId)
                .IsOptional();

            // Relationships
            this.HasRequired(t => t.Work)
                .WithMany(t => t.MapWorks)
                .HasForeignKey(t => t.WorkId);

            this.HasRequired(t => t.User)
                .WithMany(t => t.MapWorks)
                .HasForeignKey(t => t.UserId);

            this.HasRequired(t => t.Group)
                .WithMany(t => t.MapWorks)
                .HasForeignKey(t => t.GroupId);
        }
    }
}
