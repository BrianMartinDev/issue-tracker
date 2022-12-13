using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class CommentProjectConfiguration : IEntityTypeConfiguration<CommentProject>
    {
    public void Configure(EntityTypeBuilder<CommentProject> builder)
        {
        builder.HasData(
            new CommentProject
                {
                Id = 1,
                Name = "Very important Project Comment 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                ProjectId = 1,
                },
            new CommentProject
                {
                Id = 2,
                Name = "Very important Project Comment 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                ProjectId = 1,
                },
            new CommentProject
                {
                Id = 3,
                Name = "Very important Project Comment 3",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non rutrum ligula. Quisque ac nibh et felis vestibulum tincidunt. Mauris id vulputate risus.",
                ProjectId = 1,
                }
            );
        }
    }