using Microsoft.EntityFrameworkCore;

namespace ShoppingManagment.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts)
        {

        }
    }
}
