using Hortifruti.Models;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Controllers.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ProdutoModel> Produtos { get; set; }

        
    }
}
