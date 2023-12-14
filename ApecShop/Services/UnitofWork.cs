using ApecShop.Data;

namespace ApecShop.Services
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext dbc;

        private IGenderService? _genderService;

        public UnitOfWork(ApplicationDbContext context)
        {
           dbc = context;
        }

        private async Task<int> Commit() { 
            return await dbc.SaveChangesAsync();  
        }

    }
}
