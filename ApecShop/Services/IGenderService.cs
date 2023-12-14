using ApecShop.Data.DTOs;

namespace ApecShop.Services
{
    public interface IGenderService
    {
        Task<List<GenderSelect>> GetGenderSelect();

        Task<GenderDetail?> GetGender(int GenderId);



    }
}
