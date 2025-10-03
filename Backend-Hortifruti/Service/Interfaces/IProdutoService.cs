using Hortifruti.Domain;

namespace Hortifruti.Service.Interfaces;

public interface IProdutoService
{
    Task<IEnumerable<Produto>> ObterTodasProdutosAsync();
    Task<Produto?> ObterProdutoPorIdAsync(int id);
    Task<Produto> CriarProdutoAsync(Produto produto);
    Task AtualizarProdutoAsync(int id, Produto produto);
    Task DeletarProdutoAsync(int id);
}