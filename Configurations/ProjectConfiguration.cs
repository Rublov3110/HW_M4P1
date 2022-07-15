using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW_M4L3
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .ToTable("Project")
                .HasKey(p => p.ID);

            builder.Property(p => p.Name)
             .HasColumnType("nvarchar(50)");

            builder.Property(p => p.Budget)
              .HasColumnType("money");

            builder.Property(p => p.StartedDate)
              .HasColumnType("datetime2(7)");
        }
    }
}
