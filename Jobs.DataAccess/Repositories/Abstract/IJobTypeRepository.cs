namespace Jobs.DataAccess.Repositories.Abstract
{
    using Jobs.Domain.Models;
    public interface IJobTypeRepository
    {
        IEnumerable<JobType> GetJobTypes();
    }
}
