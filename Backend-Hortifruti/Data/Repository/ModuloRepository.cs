using Hortifruti.Controllers.Data;
using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Data.Repository;

public class ModuloRepository : IModuloRepository
{
    private readonly AppDbContext _context;

    public ModuloRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Modulo>> ObterTodasAsync()
    {
        return await _context.Modulo.ToListAsync();
    }

    public async Task<Modulo?> ObterPorIdAsync(int id)
    {
        return await _context.Modulo.FindAsync(id);
    }

    public async Task<Modulo> AdicionarAsync(Modulo modulo)
    {
        _context.Modulo.Add(modulo);
        await _context.SaveChangesAsync();
        return modulo;
    }

    public async Task AtualizarAsync(Modulo modulo)
    {
        _context.Entry(modulo).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var modulo = await ObterPorIdAsync(id);
        
        if (modulo != null)
        {
            _context.Modulo.Remove(modulo);
            await _context.SaveChangesAsync();
        }
    }
}