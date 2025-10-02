using Hortifruti.Data.Repository;
using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Controllers.Data
{
    public class Antigo_AppDbContext : DbContext
    {

        public Antigo_AppDbContext(DbContextOptions<Antigo_AppDbContext> options) : base(options)
        {

        }

        // public DbSet<Produto> Produto { get; set; }
        
        // public DbSet<Categoria> Categoria { get; set; }

        // public DbSet<Fornecedor> Fornecedor { get; set; }

        // public DbSet<Unidade_medida> Unidade_medida { get; set; }

        // public DbSet<Funcionario> Funcionario { get; set; }
        
        // public DbSet<Motivo_movimentacao> Motivo_movimentacao { get; set; }
    }
}