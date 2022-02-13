namespace Jobs.DataAccess.Configurations
{
    using Jobs.Domain.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class JobTypeEntityTypeConfiguration : IEntityTypeConfiguration<JobType>
    {
        public void Configure(EntityTypeBuilder<JobType> builder)
        {
            builder.HasKey("Id");
            builder.Property(jt => jt.Name).HasMaxLength(80).IsRequired();
        }
    }
}
