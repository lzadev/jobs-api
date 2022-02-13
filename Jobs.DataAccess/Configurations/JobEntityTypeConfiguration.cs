namespace Jobs.DataAccess.Configurations
{
    using Jobs.Domain.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class JobEntityTypeConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            //job info
            builder.HasKey("Id");
            builder.Property(j => j.Title).HasMaxLength(100).IsRequired();
            builder.Property(j => j.Location).HasMaxLength(80).IsRequired();
            builder.Property(j => j.Description).IsRequired();
            builder.Property(j => j.PublishedAt).IsRequired()
                .HasDefaultValue(DateTimeOffset.UtcNow);
            builder.Property(j => j.IsDelete).HasDefaultValue(false);

            //Business info
            builder.Property(j => j.BusinessName).HasMaxLength(100).IsRequired();
            builder.Property(j => j.ContactName).HasMaxLength(100).IsRequired();
            builder.Property(j => j.Email).HasMaxLength(100);
            builder.Property(j => j.PhoneNumber).HasMaxLength(20);
            builder.Property(j => j.EmailToReceiveCV).HasMaxLength(50).IsRequired();

            //relationship
            builder.HasOne(j => j.JobType)
                .WithMany(j => j.Jobs)
                .HasForeignKey(j => j.JobTypeId);


        }
    }
}
