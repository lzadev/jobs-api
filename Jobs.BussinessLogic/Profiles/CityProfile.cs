namespace Jobs.BussinessLogic.Profiles
{
    using AutoMapper;
    using Jobs.BussinessLogic.DTOs;
    using Jobs.DataAccess.Models;
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityDto>()
                .ForMember(dst => dst.Province, opt => opt.MapFrom(src => $"{src.Province} - {src.Capital}"));
        }
    }
}
