namespace Jobs.BussinessLogic.Services.Abstract
{
    using Jobs.BussinessLogic.DTOs;
    public interface ICityService
    {
        Task<IEnumerable<CityDto>> GetAllCities();
    }
}
