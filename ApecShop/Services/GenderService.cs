using ApecShop.Data;
using ApecShop.Data.DTOs;
using ApecShop.Data.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<GenderSelect>> GetGenderSelect()
        {
            var genders = from g in dbc.Genders
                          orderby g.Title
                          select new GenderSelect
                          {
                              GenderID = g.GenderID,
                              Title = g.Title
                          };
            return await genders.ToListAsync();
        }

        public void Update(GenderDetail genderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
