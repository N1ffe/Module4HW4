using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entities;

namespace Module4HW4.EntityConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired().HasColumnType("money");
            builder.Property(p => p.StartedDate).IsRequired();
            builder.HasOne(p => p.Client).WithMany(c => c.Projects).HasForeignKey(p => p.ClientId).OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<Project>()
            {
                new Project() { ProjectId = 1, Name = "test_name1", Budget = 1000m, StartedDate = new DateTime(2023, 1, 1), ClientId = 1 },
                new Project() { ProjectId = 2, Name = "test_name2", Budget = 500m, StartedDate = new DateTime(2023, 2, 1), ClientId = 2 },
                new Project() { ProjectId = 3, Name = "test_name3", Budget = 7000m, StartedDate = new DateTime(2023, 4, 1), ClientId = 3 },
                new Project() { ProjectId = 4, Name = "test_name4", Budget = 8000m, StartedDate = new DateTime(2023, 8, 1), ClientId = 4 },
                new Project() { ProjectId = 5, Name = "test_name5", Budget = 1500m, StartedDate = new DateTime(2023, 9, 1), ClientId = 5 },
            });
        }
    }
}
