using Hortifruti.Data.Repository;
using Hortifruti.Domain;

namespace Hortifruti.Service;

public class Motivo_movimentacaoService : IMotivo_movimentacaoService
{
    private readonly IMotivo_movimentacaoRepository _motivo_movimentacaoRepository;

    public Motivo_movimentacaoService(IMotivo_movimentacaoRepository motivo_movimentacaoRepository)
    {
        _motivo_movimentacaoRepository = motivo_movimentacaoRepository;
    }

    public async Task<IEnumerable<Motivo_movimentacao>> ObterTodosMotivo_movimentacaoAsync()
    {
        return await _motivo_movimentacaoRepository.ObterTodasAsync();
    }

    public async Task<Motivo_movimentacao?> ObterMotivo_movimentacaoPorIdAsync(int id)
    {
        return await _motivo_movimentacaoRepository.ObterPorIdAsync(id);
    }

    public async Task<Motivo_movimentacao> CriarMotivo_movimentacaoAsync(Motivo_movimentacao motivo_movimentacao)
    {
        return await _motivo_movimentacaoRepository.AdicionarAsync(motivo_movimentacao);
    }

    public async Task AtualizarMotivo_movimentacaoAsync(int id, Motivo_movimentacao motivo_movimentacao)
    {
        if (id != motivo_movimentacao.Id)
        {
            // Lançar erro/exceção
            return;
        }
        await _motivo_movimentacaoRepository.AtualizarAsync(motivo_movimentacao);
    }

    public async Task DeletarMotivo_movimentacaoAsync(int id)
    {
        await _motivo_movimentacaoRepository.DeletarAsync(id);
    }
}