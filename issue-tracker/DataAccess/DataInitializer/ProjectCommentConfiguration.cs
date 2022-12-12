using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class ProjectCommentConfiguration : IEntityTypeConfiguration<ProjectComment>
    {
    public void Configure(EntityTypeBuilder<ProjectComment> builder)
        {
        builder.HasData(
            new ProjectComment
                {
                Id = 1,
                Name = "Very important Project Comment 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                ProjectId = 1,
                },
            new ProjectComment
                {
                Id = 2,
                Name = "Very important Project Comment 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                ProjectId = 1,
                },
            new ProjectComment
                {
                Id = 3,
                Name = "Very important Project Comment 3",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                ProjectId = 1,
                }
            );
        }
    }