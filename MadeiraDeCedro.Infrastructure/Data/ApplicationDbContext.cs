using MadeiraDeCedro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MadeiraDeCedro.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
            
    public DbSet<Servicos> Serviços { get; set; }
    }
}
