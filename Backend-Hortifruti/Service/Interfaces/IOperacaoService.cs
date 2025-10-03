using Hortifruti.Domain;

namespace Hortifruti.Service.Interfaces;

public interface IOperacaoService
{
    Task<IEnumerable<Operacao>> ObterTodasOperacaosAsync();
    Task<Operacao?> ObterOperacaoPorIdAsync(int id);
    Task<Operacao> CriarOperacaoAsync(Operacao operacao);
    Task AtualizarOperacaoAsync(int id, Operacao operacao);
    Task DeletarOperacaoAsync(int id);
}