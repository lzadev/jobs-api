using Jobs.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Jobs.DataAccess.Contexts
{
    public class JobContext : DbContext
    {

        public DbSet<Job> Jobs { get; set; }

        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {

        }
    }
}
