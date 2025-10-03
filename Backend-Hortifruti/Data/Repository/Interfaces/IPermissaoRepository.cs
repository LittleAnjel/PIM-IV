using Hortifruti.Domain;

namespace Hortifruti.Data.Repository.Interfaces;

public interface IPermissaoRepository
{
    Task<IEnumerable<Permissao>> ObterTodasAsync();
    Task<Permissao?> ObterPorIdAsync(int id);
    Task<Permissao> AdicionarAsync(Permissao permissao);
    Task AtualizarAsync(Permissao permissao);
    Task DeletarAsync(int id);
}