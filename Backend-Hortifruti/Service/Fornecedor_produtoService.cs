using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;

namespace Hortifruti.Service;


public class Fornecedor_produtoService : IFornecedor_produtoService
{
    private readonly IFornecedor_produtoRepository _fornecedor_produtoRepository;

    public Fornecedor_produtoService(IFornecedor_produtoRepository fornecedor_produtoRepository)
    {
        _fornecedor_produtoRepository = fornecedor_produtoRepository;
    }

    public async Task<IEnumerable<Fornecedor_produto>> ObterTodasFornecedor_produtosAsync()
    {
        return await _fornecedor_produtoRepository.ObterTodasAsync();
    }

    public async Task<Fornecedor_produto?> ObterFornecedor_produtoPorIdAsync(int fornecedorId, int produtoId)
    {
        return await _fornecedor_produtoRepository.ObterPorIdAsync(fornecedorId, produtoId);
    }

    public async Task<Fornecedor_produto> CriarFornecedor_produtoAsync(Fornecedor_produto fornecedor_produto)
    {
        return await _fornecedor_produtoRepository.AdicionarAsync(fornecedor_produto);
    }

    public async Task AtualizarFornecedor_produtoAsync(int fornecedorId, int produtoId, Fornecedor_produto fornecedor_produto)
    {
        if (fornecedorId != fornecedor_produto.FornecedorId || produtoId != fornecedor_produto.ProdutoId)
        {
            // Lançar erro/exceção | [new argumentexception]?
            return;
        }
        await _fornecedor_produtoRepository.AtualizarAsync(fornecedor_produto);
    }

    public async Task DeletarFornecedor_produtoAsync(int fornecedorId, int produtoId)
    {
        await _fornecedor_produtoRepository.DeletarAsync(fornecedorId, produtoId);
    }
}

