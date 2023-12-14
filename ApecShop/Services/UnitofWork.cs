using ApecShop.Data;

namespace ApecShop.Services
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext dbc;

        private GenderService _genderService = null!;

        public UnitOfWork(ApplicationDbContext context)
        {
           dbc = context;
        }

        public GenderService GenderService => _genderService ??= new GenderService(dbc);

        public async Task<int> Commit() { 
            return await dbc.SaveChangesAsync();  
        }

    }
}
