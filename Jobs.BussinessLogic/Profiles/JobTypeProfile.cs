namespace Jobs.BussinessLogic.Profiles
{
    using AutoMapper;
    using Jobs.BussinessLogic.DTOs;
    using Jobs.Domain.Models;
    public class JobTypeProfile : Profile
    {
        public JobTypeProfile()
        {
            CreateMap<CreateJobTypeDto, JobType>();
            CreateMap<JobType, JobTypeDto>();
        }
    }
}
