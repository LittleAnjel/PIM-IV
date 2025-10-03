using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;

namespace Hortifruti.Service;


public class ModuloService : IModuloService
{
    private readonly IModuloRepository _moduloRepository;

    public ModuloService(IModuloRepository moduloRepository)
    {
        _moduloRepository = moduloRepository;
    }

    public async Task<IEnumerable<Modulo>> ObterTodasModulosAsync()
    {
        return await _moduloRepository.ObterTodasAsync();
    }

    public async Task<Modulo?> ObterModuloPorIdAsync(int id)
    {
        return await _moduloRepository.ObterPorIdAsync(id);
    }

    public async Task<Modulo> CriarModuloAsync(Modulo modulo)
    {
        return await _moduloRepository.AdicionarAsync(modulo);
    }

    public async Task AtualizarModuloAsync(int id, Modulo modulo)
    {
        if (id != modulo.Id)
        {
            // Lançar erro/exceção
            return;
        }
        await _moduloRepository.AtualizarAsync(modulo);
    }

    public async Task DeletarModuloAsync(int id)
    {
        await _moduloRepository.DeletarAsync(id);
    }
}

