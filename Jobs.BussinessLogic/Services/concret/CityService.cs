namespace Jobs.BussinessLogic.Services.concret
{
    using AutoMapper;
    using Jobs.BussinessLogic.DTOs;
    using Jobs.BussinessLogic.Services.Abstract;
    using Jobs.DataAccess.Repositories.Abstract;

    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CityDto>> GetAllCities()
        {
            try
            {
                var response = await _cityRepository.GetAllCities();

                return _mapper.Map<IEnumerable<CityDto>>(response.Data);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
