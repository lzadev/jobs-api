namespace Jobs.DataAccess.Abstract.UnitOfWork
{
    using Jobs.DataAccess.Repositories.Abstract;
    public interface IUnitOfWork : IDisposable
    {
        IJobRepository JobRepository { get; }
        IJobTypeRepository JobTypeRepository { get; }
        Task<int> Commit();
    }
}
