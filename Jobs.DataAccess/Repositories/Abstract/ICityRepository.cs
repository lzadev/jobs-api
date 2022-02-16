namespace Jobs.DataAccess.Repositories.Abstract
{
    using Jobs.DataAccess.Models;
    public interface ICityRepository
    {
        Task<CityReponse> GetAllCities();
    }
}
