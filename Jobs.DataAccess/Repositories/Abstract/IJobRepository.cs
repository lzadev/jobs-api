namespace Jobs.DataAccess.Repositories.Abstract
{
    using Jobs.Domain.Models;

    public interface IJobRepository
    {
        IEnumerable<Job> GetAll();
        IEnumerable<Job> GetAll(Func<Job, bool> func);
        Job GetById(int id);
        void Add(Job job);
        void Update(Job job);
        void Delete(Job job);
    }
}
