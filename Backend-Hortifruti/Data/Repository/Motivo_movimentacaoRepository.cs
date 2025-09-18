using Hortifruti.Controllers.Data;
using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Data.Repository;

public class Motivo_movimentacaoRepository : IMotivo_movimentacaoRepository
{
    private readonly AppDbContext _context;

    public Motivo_movimentacaoRepository(AppDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Motivo_movimentacao>> ObterTodasAsync()
    {
        return await _context.Motivo_movimentacao.ToListAsync();
    }

    public async Task<Motivo_movimentacao?> ObterPorIdAsync(int id)
    {
        return await _context.Motivo_movimentacao.FindAsync();
    }

    public async Task<Motivo_movimentacao> AdicionarAsync(Motivo_movimentacao motivo_movimentacao)
    {
        _context.Motivo_movimentacao.Add(motivo_movimentacao);
        await _context.SaveChangesAsync();
        return motivo_movimentacao;
    }

    public async Task AtualizarAsync(Motivo_movimentacao motivo_movimentacao)
    {
        _context.Entry(motivo_movimentacao).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var motivo_movimentacao = await ObterPorIdAsync(id);
        
        if (motivo_movimentacao != null)
        {
            _context.Motivo_movimentacao.Remove(motivo_movimentacao);
            await _context.SaveChangesAsync();
        }
    }
}