using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entities;

namespace Module4HW4.EntityConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(c => c.ClientId);
            builder.Property(c => c.ClientId).ValueGeneratedOnAdd();
            builder.Property(c => c.CompanyName).HasMaxLength(100);
            builder.Property(c => c.FirstName).HasMaxLength(50);
            builder.Property(c => c.LastName).HasMaxLength(50);
            builder.Property(c => c.Country).IsRequired().HasMaxLength(50);

            builder.HasData(new List<Client>()
            {
                new Client() { ClientId = 1, CompanyName = "test_company_name1", FirstName = "test_first_name1", LastName = "test_last_name1", Country = "Poland" },
                new Client() { ClientId = 2, FirstName = "test_first_name2", LastName = "test_last_name2", Country = "UK" },
                new Client() { ClientId = 3, CompanyName = "test_company_name2", Country = "USA" },
                new Client() { ClientId = 4, CompanyName = "test_company_name3", FirstName = "test_first_name3", LastName = "test_last_name3", Country = "USA" },
                new Client() { ClientId = 5, CompanyName = "test_company_name4", Country = "Canada" }
            });
        }
    }
}
