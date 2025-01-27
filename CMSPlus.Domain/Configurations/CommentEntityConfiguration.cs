using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CMSPlus.Domain.Entities;

namespace CMSPlus.Domain.Configurations;

public class CommentEntityConfiguration : IEntityTypeConfiguration<CommentEntity>
{
    public void Configure(EntityTypeBuilder<CommentEntity> builder)
    {
        builder.ToTable("Comments");
        builder.Property(x => x.Body).IsRequired();
        builder.Property(x => x.FullName).IsRequired();
        builder.HasOne(x => x.Topic).WithMany(x => x.Comments).HasForeignKey(x => x.TopicId);
    }
}

