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

    public async Task<Unidade_medida> AdicionarAsync(Unidade_medida unidade_medida)
    {
        _context.Unidade_medida.Add(unidade_medida);
        await _context.SaveChangesAsync();
        return unidade_medida;
    }

    public async Task AtualizarAsync(Unidade_medida unidade_medida)
    {
        _context.Entry(unidade_medida).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var unidade_medida = await ObterPorIdAsync(id);

        if (unidade_medida != null)
        {
            _context.Unidade_medida.Remove(unidade_medida);
            await _context.SaveChangesAsync();
        }
    }
}