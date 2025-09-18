using Hortifruti.Controllers.Data;
using Hortifruti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hortifruti.Data.Repository;

public class FuncionarioRepository : IFuncionarioRepository
{
    private readonly AppDbContext _context;

    public FuncionarioRepository(AppDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Funcionario>> ObterTodasAsync()
    {
        return await _context.Funcionario.ToListAsync();
    }

    public async Task<Funcionario?> ObterPorIdAsync(int id)
    {
        return await _context.Funcionario.FindAsync(id);
    }

    public async Task<Funcionario> AdicionarAsync(Funcionario funcionario)
    {
        _context.Funcionario.Add(funcionario);
        await _context.SaveChangesAsync();
        return funcionario;
    }

    public async Task AtualizarAsync(Funcionario funcionario)
    {
        _context.Entry(funcionario).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var funcionario = await ObterPorIdAsync(id);

        if (funcionario != null)
        {
            _context.Funcionario.Remove(funcionario);
            await _context.SaveChangesAsync();
        }
    }
}