using Hortifruti.Controllers.Data;
using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Data.Repository;

public class PermissaoRepository : IPermissaoRepository
{
    private readonly AppDbContext _context;

    public PermissaoRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Permissao>> ObterTodasAsync()
    {
        return await _context.Permissao.ToListAsync();
    }

    public async Task<Permissao?> ObterPorIdAsync(int id)
    {
        return await _context.Permissao.FindAsync(id);
    }

    public async Task<Permissao> AdicionarAsync(Permissao permissao)
    {
        _context.Permissao.Add(permissao);
        await _context.SaveChangesAsync();
        return permissao;
    }

    public async Task AtualizarAsync(Permissao permissao)
    {
        _context.Entry(permissao).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var permissao = await ObterPorIdAsync(id);
        
        if (permissao != null)
        {
            _context.Permissao.Remove(permissao);
            await _context.SaveChangesAsync();
        }
    }
}