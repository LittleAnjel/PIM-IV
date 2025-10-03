using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;

namespace Hortifruti.Service;


public class OperacaoService : IOperacaoService
{
    private readonly IOperacaoRepository _operacaoRepository;

    public OperacaoService(IOperacaoRepository operacaoRepository)
    {
        _operacaoRepository = operacaoRepository;
    }

    public async Task<IEnumerable<Operacao>> ObterTodasOperacaosAsync()
    {
        return await _operacaoRepository.ObterTodasAsync();
    }

    public async Task<Operacao?> ObterOperacaoPorIdAsync(int id)
    {
        return await _operacaoRepository.ObterPorIdAsync(id);
    }

    public async Task<Operacao> CriarOperacaoAsync(Operacao operacao)
    {
        return await _operacaoRepository.AdicionarAsync(operacao);
    }

    public async Task AtualizarOperacaoAsync(int id, Operacao operacao)
    {
        if (id != operacao.Id)
        {
            // Lançar erro/exceção
            return;
        }
        await _operacaoRepository.AtualizarAsync(operacao);
    }

    public async Task DeletarOperacaoAsync(int id)
    {
        await _operacaoRepository.DeletarAsync(id);
    }
}

