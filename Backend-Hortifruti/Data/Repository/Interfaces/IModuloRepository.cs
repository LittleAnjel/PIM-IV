using Hortifruti.Domain;

namespace Hortifruti.Data.Repository.Interfaces;

public interface IModuloRepository
{
    Task<IEnumerable<Modulo>> ObterTodasAsync();
    Task<Modulo?> ObterPorIdAsync(int id);
    Task<Modulo> AdicionarAsync(Modulo modulo);
    Task AtualizarAsync(Modulo modulo);
    Task DeletarAsync(int id);
}