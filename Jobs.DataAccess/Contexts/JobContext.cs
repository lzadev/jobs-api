namespace Jobs.DataAccess.Contexts
{
    using Jobs.DataAccess.Configurations;
    using Jobs.Domain.Models;
    using Microsoft.EntityFrameworkCore;

    public class JobContext : DbContext
    {

        public DbSet<Job> Jobs { get; set; }

        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JobEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobTypeEntityTypeConfiguration());
        }
    }
}
