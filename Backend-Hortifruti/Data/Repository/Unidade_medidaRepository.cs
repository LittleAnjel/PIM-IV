using Hortifruti.Controllers.Data;
using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Data.Repository;

public class Unidade_medidaRepository : IUnidade_medidaRepository
{
    private readonly AppDbContext _context;

    public Unidade_medidaRepository(AppDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Unidade_medida>> ObterTodasAsync()
    {
        return await _context.Unidade_medida.ToListAsync();
    }

    public async Task<Unidade_medida?> ObterPorIdAsync(int id)
    {
        return await _context.Unidade_medida.FindAsync(id);
    }

    public async Task<Unidade_medida> AdicionarAsync(Unidade_medida fornecedor)
    {
        _context.Unidade_medida.Add(fornecedor);
        await _context.SaveChangesAsync();
        return fornecedor;
    }

    public async Task AtualizarAsync(Unidade_medida fornecedor)
    {
        _context.Entry(fornecedor).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var fornecedor = await ObterPorIdAsync(id);

        if (fornecedor != null)
        {
            _context.Unidade_medida.Remove(fornecedor);
            await _context.SaveChangesAsync();
        }
    }
}