using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Controllers.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
        
        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Fornecedor> Fornecedor { get; set; }
        
    }
}