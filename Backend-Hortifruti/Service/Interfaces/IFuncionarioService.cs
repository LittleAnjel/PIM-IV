using Hortifruti.Domain;

namespace Hortifruti.Service.Interfaces;

public interface IFuncionarioService
{
    Task<IEnumerable<Funcionario>> ObterTodosFuncionarioAsync();
    Task<Funcionario?> ObterFuncionarioPorIdAsync(int id);
    Task<Funcionario> CriarFuncionarioAsync(Funcionario funcionario);
    Task AtualizarFuncionarioAsync(int id, Funcionario funcionario);
    Task DeletarFuncionarioAsync(int id);
}