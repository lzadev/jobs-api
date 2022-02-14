namespace Jobs.DataAccess.Repositories.Concret
{
    using Jobs.DataAccess.Contexts;
    using Jobs.DataAccess.Repositories.Abstract;
    using Jobs.Domain.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

#nullable disable
    public class JobRepository : IJobRepository
    {
        private readonly JobContext context;
        private DbSet<Job> dbset;

        public JobRepository(JobContext context)
        {
            this.context = context;
            dbset = context.Set<Job>();
        }

        public IEnumerable<Job> GetAll()
        {
            return dbset.ToList();
        }

        public IEnumerable<Job> GetAll(Func<Job, bool> func)
        {
            return dbset.Where(func).ToList();
        }

        public Job GetById(int id)
        {
            return dbset.Find(id);
        }

        public void Add(Job job)
        {
            dbset.Add(job);
        }

        public void Update(Job job)
        {
            dbset.Update(job);
        }

        public void Delete(Job job)
        {
            dbset.Remove(job);
        }
    }
}
