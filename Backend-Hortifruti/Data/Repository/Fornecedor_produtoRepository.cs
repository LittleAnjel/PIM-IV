using Hortifruti.Controllers.Data;
using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Data.Repository;

public class Fornecedor_produtoRepository : IFornecedor_produtoRepository
{
    private readonly AppDbContext _context;

    public Fornecedor_produtoRepository(AppDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Fornecedor_produto>> ObterTodasAsync()
    {
        return await _context.Fornecedor_produto.ToListAsync();
    }

    public async Task<Fornecedor_produto?> ObterPorIdAsync(int fornecedorId, int produtoId)
    {
        return await _context.Fornecedor_produto.FindAsync(fornecedorId, produtoId);
    }

    public async Task<Fornecedor_produto> AdicionarAsync(Fornecedor_produto fornecedor_produto)
    {
        _context.Fornecedor_produto.Add(fornecedor_produto);
        await _context.SaveChangesAsync();
        return fornecedor_produto;
    }

    public async Task AtualizarAsync(Fornecedor_produto fornecedor_produto)
    {
        _context.Entry(fornecedor_produto).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int fornecedorId, int produtoId)
    {
        var fornecedor_produto = await ObterPorIdAsync(fornecedorId, produtoId);

        if (fornecedor_produto != null)
        {
            _context.Fornecedor_produto.Remove(fornecedor_produto);
            await _context.SaveChangesAsync();
        }
    }
}