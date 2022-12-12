using issue_tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {
    public void Configure(EntityTypeBuilder<Issue> builder)
        {
        builder.HasData(

            new Issue
                {
                Id = 1,
                Name = "Very important Issue 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                ProjectId = 1,
                },

            new Issue
                {
                Id = 2,
                Name = "Very important Issue 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                ProjectId = 1,
                },

            new Issue
                {
                Id = 3,
                Name = "Very important Issue 3",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                ProjectId = 1,
                }
            );
        }
    }