using Hortifruti.Domain;

namespace Hortifruti.Data.Repository;

public interface ICategoriaRepository
{
    Task<IEnumerable<Categoria>> ObterTodasAsync();
    Task<Categoria?> ObterPorIdAsync(int id);
    Task<Categoria> AdicionarAsync(Categoria categoria);
    Task AtulizarAsync(Categoria categoria);
    Task DeletarAsync(int id);
}