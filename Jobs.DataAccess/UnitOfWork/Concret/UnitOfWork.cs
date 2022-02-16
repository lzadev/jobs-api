namespace Jobs.DataAccess.Concret.UnitOfWork
{
    using Jobs.DataAccess.Abstract.UnitOfWork;
    using Jobs.DataAccess.Contexts;
    using Jobs.DataAccess.Repositories.Abstract;
    using Jobs.DataAccess.Repositories.Concret;
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly JobContext context;

        public UnitOfWork(JobContext context)
        {
            this.context = context;
        }
        public IJobRepository JobRepository => JobRepository ?? new JobRepository(context);
        public IJobTypeRepository JobTypeRepository => JobTypeRepository ?? new JobTypeRepository(context);
        public async Task<int> Commit() => await context.SaveChangesAsync();
        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }
    }


}
