using Hortifruti.Domain;

namespace Hortifruti.Data.Repository.Interfaces;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> ObterTodasAsync();
    Task<Produto?> ObterPorIdAsync(int id);
    Task<Produto> AdicionarAsync(Produto produto);
    Task AtualizarAsync(Produto produto);
    Task DeletarAsync(int id);
}