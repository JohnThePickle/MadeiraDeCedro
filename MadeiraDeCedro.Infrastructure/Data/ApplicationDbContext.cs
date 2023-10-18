using Microsoft.EntityFrameworkCore;

namespace MadeiraDeCedro.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
            
    
    }
}
