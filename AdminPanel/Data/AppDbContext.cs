using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts)
        {

        }
    }
}
