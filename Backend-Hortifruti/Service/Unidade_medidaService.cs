using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;

namespace Hortifruti.Service;

public class Unidade_medidaService : IUnidade_medidaService
{
    private readonly IUnidade_medidaRepository _unidade_medidaRepository;

    public Unidade_medidaService(IUnidade_medidaRepository unidade_medidaRepository)
    {
        _unidade_medidaRepository = unidade_medidaRepository;
    }

    public async Task<IEnumerable<Unidade_medida>> ObterTodosUnidade_medidaAsync()
    {
        return await _unidade_medidaRepository.ObterTodasAsync();
    }

    public async Task<Unidade_medida?> ObterUnidade_medidaPorIdAsync(int id)
    {
        return await _unidade_medidaRepository.ObterPorIdAsync(id);
    }

    public async Task<Unidade_medida> CriarUnidade_medidaAsync(Unidade_medida unidade_medida)
    {
        return await _unidade_medidaRepository.AdicionarAsync(unidade_medida);
    }

    public async Task AtualizarUnidade_medidaAsync(int id, Unidade_medida unidade_medida)
    {
        if (id != unidade_medida.Id)
        {
            // Lançar erro/exceção
            return;
        }
        await _unidade_medidaRepository.AtualizarAsync(unidade_medida);
    }

    public async Task DeletarUnidade_medidaAsync(int id)
    {
        await _unidade_medidaRepository.DeletarAsync(id);
    }
}