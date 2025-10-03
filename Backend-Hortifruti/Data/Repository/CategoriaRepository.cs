using Hortifruti.Controllers.Data;
using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Data.Repository;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;

    public CategoriaRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Categoria>> ObterTodasAsync()
    {
        return await _context.Categoria.ToListAsync();
    }

    public async Task<Categoria?> ObterPorIdAsync(int id)
    {
        return await _context.Categoria.FindAsync(id);
    }

    public async Task<Categoria> AdicionarAsync(Categoria categoria)
    {
        _context.Categoria.Add(categoria);
        await _context.SaveChangesAsync();
        return categoria;
    }

    public async Task AtualizarAsync(Categoria categoria)
    {
        _context.Entry(categoria).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var categoria = await ObterPorIdAsync(id);
        
        if (categoria != null)
        {
            _context.Categoria.Remove(categoria);
            await _context.SaveChangesAsync();
        }
    }
}