using Hortifruti.Domain;

namespace Hortifruti.Data.Repository.Interfaces;

 public interface IUnidade_medidaRepository
{
    Task<IEnumerable<Unidade_medida>> ObterTodasAsync();
    Task<Unidade_medida?> ObterPorIdAsync(int id);
    Task<Unidade_medida> AdicionarAsync(Unidade_medida unidade_medida);
    Task AtualizarAsync(Unidade_medida unidade_medida);
    Task DeletarAsync(int id);
}
