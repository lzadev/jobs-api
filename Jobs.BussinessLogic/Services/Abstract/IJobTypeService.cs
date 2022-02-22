
namespace Jobs.BussinessLogic.Services.Abstract
{
    using Jobs.BussinessLogic.DTOs;
    public interface IJobTypeService
    {
        Task<IEnumerable<JobTypeDto>> GetAllJobTypes();
        Task<JobTypeDto> CreateJobtType(CreateJobTypeDto item);

    }
}
