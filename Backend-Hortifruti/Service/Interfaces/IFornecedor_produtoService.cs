using Hortifruti.Domain;

namespace Hortifruti.Service.Interfaces;

public interface IFornecedor_produtoService
{
    Task<IEnumerable<Fornecedor_produto>> ObterTodasFornecedor_produtosAsync();
    Task<Fornecedor_produto?> ObterFornecedor_produtoPorIdAsync(int fornecedorId, int produtoId);
    Task<Fornecedor_produto> CriarFornecedor_produtoAsync(Fornecedor_produto categoria);
    Task AtualizarFornecedor_produtoAsync(int fornecedorId, int produtoId, Fornecedor_produto categoria);
    Task DeletarFornecedor_produtoAsync(int fornecedorId, int produtoId);
}