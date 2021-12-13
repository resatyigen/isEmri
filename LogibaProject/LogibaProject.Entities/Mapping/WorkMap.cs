using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Entities.Mapping
{
    public class WorkMap:EntityTypeConfiguration<Work>
    {
        public WorkMap()
        {
            this.HasKey(t => t.id);

            this.Property(t => t.Name).HasMaxLength(150);
            this.Property(t => t.Material).HasMaxLength(250);
            this.Property(t => t.Description).HasMaxLength(300);
            this.Property(t => t.FileName).HasMaxLength(150);

            // Table & Column Mapping

            this.ToTable("Works");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.No).HasColumnName("No");
            this.Property(t => t.Material).HasColumnName("Material");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.Status).HasColumnName("Status");

        }
    }
}
