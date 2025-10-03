using Hortifruti.Domain;

namespace Hortifruti.Service.Interfaces;

public interface IModuloService
{
    Task<IEnumerable<Modulo>> ObterTodasModulosAsync();
    Task<Modulo?> ObterModuloPorIdAsync(int id);
    Task<Modulo> CriarModuloAsync(Modulo modulo);
    Task AtualizarModuloAsync(int id, Modulo modulo);
    Task DeletarModuloAsync(int id);
}