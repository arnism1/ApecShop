using ApecShop.Data;
using ApecShop.Data.DTOs;
using ApecShop.Data.Models;

namespace ApecShop.Services
{
    public class GenderService : IGenderService
    {
        private ApplicationDbContext dbc;

        public GenderService (ApplicationDbContext context)
        {
            dbc = context;
        }

        public void Add(GenderDetail genderDetail)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gender gender)
        {
            throw new NotImplementedException();
        }

        public void Delete(int GenderID)
        {
            throw new NotImplementedException();
        }

        public Task<GenderDetail?> GetGender(int GenderID)
        {
            throw new NotImplementedException();
        }

        public Task<List<GenderSelect>> GetGenderSelect()
        {
            throw new NotImplementedException();
        }

        public void Update(GenderDetail genderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
