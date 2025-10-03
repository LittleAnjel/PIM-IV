using Hortifruti.Domain;

namespace Hortifruti.Service.Interfaces;

public interface IPermissaoService
{
    Task<IEnumerable<Permissao>> ObterTodasPermissaosAsync();
    Task<Permissao?> ObterPermissaoPorIdAsync(int id);
    Task<Permissao> CriarPermissaoAsync(Permissao permissao);
    Task AtualizarPermissaoAsync(int id, Permissao permissao);
    Task DeletarPermissaoAsync(int id);
}