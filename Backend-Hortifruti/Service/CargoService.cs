using Hortifruti.Data.Repository.Interfaces;
using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;

namespace Hortifruti.Service;


public class CargoService : ICargoService
{
    private readonly ICargoRepository _cargoRepository;

    public CargoService(ICargoRepository cargoRepository)
    {
        _cargoRepository = cargoRepository;
    }

    public async Task<IEnumerable<Cargo>> ObterTodasCargosAsync()
    {
        return await _cargoRepository.ObterTodasAsync();
    }

    public async Task<Cargo?> ObterCargoPorIdAsync(int id)
    {
        return await _cargoRepository.ObterPorIdAsync(id);
    }

    public async Task<Cargo> CriarCargoAsync(Cargo cargo)
    {
        return await _cargoRepository.AdicionarAsync(cargo);
    }

    public async Task AtualizarCargoAsync(int id, Cargo cargo)
    {
        if (id != cargo.Id)
        {
            // Lançar erro/exceção
            return;
        }
        await _cargoRepository.AtualizarAsync(cargo);
    }

    public async Task DeletarCargoAsync(int id)
    {
        await _cargoRepository.DeletarAsync(id);
    }
}

