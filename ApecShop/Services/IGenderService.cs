using ApecShop.Data.DTOs;
using ApecShop.Data.Models;

namespace ApecShop.Services
{
    public interface IGenderService
    {
        Task<List<GenderSelect>> GetGenderSelect();

        Task<GenderDetail?> GetGender(int GenderID);

        void Add(GenderDetail genderDetail);
        void Update(GenderDetail genderDetail);
        void Delete(Gender gender);
        void Delete(int GenderID);

    }
}
