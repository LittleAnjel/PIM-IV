using Hortifruti.Domain;

namespace Hortifruti.Data.Repository.Interfaces;

public interface ICargoRepository
{
    Task<IEnumerable<Cargo>> ObterTodasAsync();
    Task<Cargo?> ObterPorIdAsync(int id);
    Task<Cargo> AdicionarAsync(Cargo cargo);
    Task AtualizarAsync(Cargo cargo);
    Task DeletarAsync(int id);
}