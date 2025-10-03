using Hortifruti.Domain;

namespace Hortifruti.Service.Interfaces;

public interface IUnidade_medidaService
{
    Task<IEnumerable<Unidade_medida>> ObterTodosUnidade_medidaAsync();
    Task<Unidade_medida?> ObterUnidade_medidaPorIdAsync(int id);
    Task<Unidade_medida> CriarUnidade_medidaAsync(Unidade_medida unidade_medida);
    Task AtualizarUnidade_medidaAsync(int id, Unidade_medida unidade_medida);
    Task DeletarUnidade_medidaAsync(int id);
}