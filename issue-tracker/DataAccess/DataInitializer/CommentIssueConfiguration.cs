using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class CommentIssueConfiguration : IEntityTypeConfiguration<CommentIssue>
    {
    public void Configure(EntityTypeBuilder<CommentIssue> builder)
        {
        builder.HasData(
            new CommentIssue
                {
                Id = 1,
                Name = "Very important Issue Comment 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                IssueId = 1,
                },
            new CommentIssue
                {
                Id = 2,
                Name = "Very important Issue Comment 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                IssueId = 1,
                },
            new CommentIssue
                {
                Id = 3,
                Name = "Very important Issue Comment 3",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                IssueId = 1,
                }
            );
        }
    }