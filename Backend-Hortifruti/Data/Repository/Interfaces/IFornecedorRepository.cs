using Hortifruti.Domain;

namespace Hortifruti.Data.Repository.Interfaces;

 public interface IFornecedorRepository
{
    Task<IEnumerable<Fornecedor>> ObterTodasAsync();
    Task<Fornecedor?> ObterPorIdAsync(int id);
    Task<Fornecedor> AdicionarAsync(Fornecedor fornecedor);
    Task AtualizarAsync(Fornecedor fornecedor);
    Task DeletarAsync(int id);
}
