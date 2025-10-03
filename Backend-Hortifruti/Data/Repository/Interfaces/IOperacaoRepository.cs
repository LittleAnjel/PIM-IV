using Hortifruti.Domain;

namespace Hortifruti.Data.Repository.Interfaces;

public interface IOperacaoRepository
{
    Task<IEnumerable<Operacao>> ObterTodasAsync();
    Task<Operacao?> ObterPorIdAsync(int id);
    Task<Operacao> AdicionarAsync(Operacao operacao);
    Task AtualizarAsync(Operacao operacao);
    Task DeletarAsync(int id);
}