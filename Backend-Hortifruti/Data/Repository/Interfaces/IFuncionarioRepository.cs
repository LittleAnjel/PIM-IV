using Hortifruti.Domain;

namespace Hortifruti.Data.Repository.Interfaces;

 public interface IFuncionarioRepository
{
    Task<IEnumerable<Funcionario>> ObterTodasAsync();
    Task<Funcionario?> ObterPorIdAsync(int id);
    Task<Funcionario> AdicionarAsync(Funcionario funcionario);
    Task AtualizarAsync(Funcionario funcionario);
    Task DeletarAsync(int id);
}
