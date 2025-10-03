using Hortifruti.Domain;

namespace Hortifruti.Data.Repository.Interfaces;

public interface ICategoriaRepository
{
    Task<IEnumerable<Categoria>> ObterTodasAsync();
    Task<Categoria?> ObterPorIdAsync(int id);
    Task<Categoria> AdicionarAsync(Categoria categoria);
    Task AtualizarAsync(Categoria categoria);
    Task DeletarAsync(int id);
}