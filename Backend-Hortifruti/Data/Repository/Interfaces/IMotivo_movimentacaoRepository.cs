using Hortifruti.Domain;

namespace Hortifruti.Data.Repository.Interfaces;

public interface IMotivo_movimentacaoRepository
{
    Task<IEnumerable<Motivo_movimentacao>> ObterTodasAsync();
    Task<Motivo_movimentacao?> ObterPorIdAsync(int id);
    Task<Motivo_movimentacao> AdicionarAsync(Motivo_movimentacao motivo_movimentacao);
    Task AtualizarAsync(Motivo_movimentacao motivo_movimentacao);
    Task DeletarAsync(int id);
}