using Hortifruti.Domain;

namespace Hortifruti.Service.Interfaces;

public interface ICargoService
{
    Task<IEnumerable<Cargo>> ObterTodasCargosAsync();
    Task<Cargo?> ObterCargoPorIdAsync(int id);
    Task<Cargo> CriarCargoAsync(Cargo cargo);
    Task AtualizarCargoAsync(int id, Cargo cargo);
    Task DeletarCargoAsync(int id);
}