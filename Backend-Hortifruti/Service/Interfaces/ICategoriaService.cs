using Hortifruti.Domain;

namespace Hortifruti.Service.Interfaces;

public interface ICategoriaService
{
    Task<IEnumerable<Categoria>> ObterTodasCategoriasAsync();
    Task<Categoria?> ObterCategoriaPorIdAsync(int id);
    Task<Categoria> CriarCategoriaAsync(Categoria categoria);
    Task AtualizarCategoriaAsync(int id, Categoria categoria);
    Task DeletarCategoriaAsync(int id);
}