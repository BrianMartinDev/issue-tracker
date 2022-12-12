using issue_tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
    public void Configure(EntityTypeBuilder<Project> builder)
        {
        builder.HasData(
            new Project
                {
                Id = 1,
                Name = "Very important Project 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                CompanyId = 1,
                },
            new Project
                {
                Id = 2,
                Name = "Very important Project 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                CompanyId = 1,
                },
            new Project
                {
                Id = 3,
                Name = "Very important Project 3",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                CompanyId = 1,
                }
            );
        }
    }
