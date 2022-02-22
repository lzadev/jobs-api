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
        public async Task<IEnumerable<JobType>> GetJobTypes()
        {
            return await dbset.OrderByDescending(jt => jt.Name).ToListAsync();
        }
        
        public async Task<JobType> Add(JobType jobType)
        {
            await dbset.AddAsync(jobType);

            return jobType;
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }
    }
}
