using Hortifruti.Data.Repository;
using Hortifruti.Domain;

namespace Hortifruti.Service;


public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoService(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task<IEnumerable<Produto>> ObterTodasProdutosAsync()
    {
        return await _produtoRepository.ObterTodasAsync();
    }

    public async Task<Produto?> ObterProdutoPorIdAsync(int id)
    {
        return await _produtoRepository.ObterPorIdAsync(id);
    }

    public async Task<Produto> CriarProdutoAsync(Produto produto)
    {
        return await _produtoRepository.AdicionarAsync(produto);
    }

    public async Task AtualizarProdutoAsync(int id, Produto produto)
    {
        if (id != produto.Id)
        {
            // Lançar erro/exceção
            return;
        }
        await _produtoRepository.AtualizarAsync(produto);
    }

    public async Task DeletarProdutoAsync(int id)
    {
        await _produtoRepository.DeletarAsync(id);
    }
}

