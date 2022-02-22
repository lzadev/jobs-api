namespace Jobs.DataAccess.Repositories.Abstract
{
    using Jobs.Domain.Models;
    public interface IJobTypeRepository
    {
        Task<IEnumerable<JobType>> GetJobTypes();
        Task<JobType> Add(JobType jobType);
        Task Save();

    }
}
