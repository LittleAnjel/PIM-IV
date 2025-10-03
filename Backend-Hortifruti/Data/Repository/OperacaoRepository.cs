using Hortifruti.Controllers.Data;
using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Data.Repository;

public class OperacaoRepository : IOperacaoRepository
{
    private readonly AppDbContext _context;

    public OperacaoRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Operacao>> ObterTodasAsync()
    {
        return await _context.Operacao.ToListAsync();
    }

    public async Task<Operacao?> ObterPorIdAsync(int id)
    {
        return await _context.Operacao.FindAsync(id);
    }

    public async Task<Operacao> AdicionarAsync(Operacao operacao)
    {
        _context.Operacao.Add(operacao);
        await _context.SaveChangesAsync();
        return operacao;
    }

    public async Task AtualizarAsync(Operacao operacao)
    {
        _context.Entry(operacao).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var operacao = await ObterPorIdAsync(id);
        
        if (operacao != null)
        {
            _context.Operacao.Remove(operacao);
            await _context.SaveChangesAsync();
        }
    }
}