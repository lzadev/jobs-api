namespace Jobs.BussinessLogic.Services.concret
{
    using AutoMapper;
    using Jobs.BussinessLogic.DTOs;
    using Jobs.BussinessLogic.Services.Abstract;
    using Jobs.DataAccess.Repositories.Abstract;
    using Jobs.Domain.Models;
    public class JobTypeService : IJobTypeService
    {
        private readonly IMapper _mapper;
        private readonly IJobTypeRepository _jobTypeRepository;

        public JobTypeService(IMapper mapper, IJobTypeRepository jobTypeRepository)
        {
            _mapper = mapper;
            _jobTypeRepository = jobTypeRepository;
        }
        public async Task<IEnumerable<JobTypeDto>> GetAllJobTypes()
        {
            var result = await _jobTypeRepository.GetJobTypes();

            return _mapper.Map<IEnumerable<JobTypeDto>>(result);
        }

        public async Task<JobTypeDto> CreateJobtType(CreateJobTypeDto item)
        {
            var jobTypeToCreate = _mapper.Map<JobType>(item);

            var result = await _jobTypeRepository.Add(jobTypeToCreate);

            await _jobTypeRepository.Save();

            return _mapper.Map<JobTypeDto>(result);
        }
    }
}
