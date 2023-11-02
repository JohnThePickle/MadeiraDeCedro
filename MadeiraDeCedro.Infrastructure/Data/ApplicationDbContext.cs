using MadeiraDeCedro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MadeiraDeCedro.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Servicos> Servicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Servicos>().HasData(new Servicos
            {
                Id = 1,
                Nome = "Restauros",
                Descrição = "Restauros de moveis antigos ou danificados, trabalhando a madeira original ou substituindo por madeira nova",
                Madeira = "Carvalho",
                Movel = "Baús",
                Imagem = "https://i.imgur.com/9ayBQNX.png",

            },
            new Servicos
            {
                Id = 2,
                Nome = "Criação",
                Descrição = "Criação e produção de moveis de raiz",
                Madeira = "Cedro",
                Movel = "Mesa",
                Imagem = "https://i.imgur.com/0hqF9zK.jpg",
            },
            new Servicos
            {
                Id = 3,
                Nome = "Instalação",
                Descrição = "Instalação de moveis ",
                Madeira = "Tola",
                Movel = "Estante",
                Imagem = "https://i.imgur.com/FvhuGug.png",
            });
        }
    }
}

