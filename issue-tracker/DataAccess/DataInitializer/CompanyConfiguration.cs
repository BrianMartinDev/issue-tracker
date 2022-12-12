using issue_tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
    public void Configure(EntityTypeBuilder<Company> builder)
        {
        builder.HasData(
            new Company
                {
                Id = 1,
                OrgName = "Very important Company 1",
                },
            new Company
                {
                Id = 2,
                OrgName = "Very important Company 2",
                },
            new Company
                {
                Id = 3,
                OrgName = "Very important Company 3",
                }
            );
        }
    }