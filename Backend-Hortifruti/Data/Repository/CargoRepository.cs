using Hortifruti.Controllers.Data;
using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Data.Repository;

public class CargoRepository : ICargoRepository
{
    private readonly AppDbContext _context;

    public CargoRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Cargo>> ObterTodasAsync()
    {
        return await _context.Cargo.ToListAsync();
    }

    public async Task<Cargo?> ObterPorIdAsync(int id)
    {
        return await _context.Cargo.FindAsync(id);
    }

    public async Task<Cargo> AdicionarAsync(Cargo cargo)
    {
        _context.Cargo.Add(cargo);
        await _context.SaveChangesAsync();
        return cargo;
    }

    public async Task AtualizarAsync(Cargo cargo)
    {
        _context.Entry(cargo).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var cargo = await ObterPorIdAsync(id);
        
        if (cargo != null)
        {
            _context.Cargo.Remove(cargo);
            await _context.SaveChangesAsync();
        }
    }
}