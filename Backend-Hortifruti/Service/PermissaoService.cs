using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;

namespace Hortifruti.Service;


public class PermissaoService : IPermissaoService
{
    private readonly IPermissaoRepository _permissaoRepository;

    public PermissaoService(IPermissaoRepository permissaoRepository)
    {
        _permissaoRepository = permissaoRepository;
    }

    public async Task<IEnumerable<Permissao>> ObterTodasPermissaosAsync()
    {
        return await _permissaoRepository.ObterTodasAsync();
    }

    public async Task<Permissao?> ObterPermissaoPorIdAsync(int id)
    {
        return await _permissaoRepository.ObterPorIdAsync(id);
    }

    public async Task<Permissao> CriarPermissaoAsync(Permissao permissao)
    {
        return await _permissaoRepository.AdicionarAsync(permissao);
    }

    public async Task AtualizarPermissaoAsync(int id, Permissao permissao)
    {
        if (id != permissao.Id)
        {
            // Lançar erro/exceção
            return;
        }
        await _permissaoRepository.AtualizarAsync(permissao);
    }

    public async Task DeletarPermissaoAsync(int id)
    {
        await _permissaoRepository.DeletarAsync(id);
    }
}

