namespace Jobs.DataAccess.Repositories.Concret
{
    using Jobs.DataAccess.Contexts;
    using Jobs.DataAccess.Repositories.Abstract;
    using Jobs.Domain.Models;
    using Microsoft.EntityFrameworkCore;
    public class JobTypeRepository : IJobTypeRepository
    {
        private readonly JobContext context;
        private DbSet<JobType> dbset;

        public JobTypeRepository(JobContext context)
        {
            this.context = context;
            dbset = this.context.Set<JobType>();
        }
        public IEnumerable<JobType> GetJobTypes()
        {
            return dbset.ToList().OrderByDescending(jt => jt.Name);
        }
    }
}
