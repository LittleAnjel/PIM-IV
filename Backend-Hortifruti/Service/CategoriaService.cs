using Hortifruti.Data.Repository;
using Hortifruti.Domain;

namespace Hortifruti.Service;

public class CategoriaService : ICategoriaService
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CategoriaService(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }
        
    public async Task<IEnumerable<Categoria>> ObterTodasCategoriasAsync()
    {
       return await _categoriaRepository.ObterTodasAsync();
    }

    public async Task<Categoria?> ObterCategoriaPorIdAsync(int id)
    {
        return await _categoriaRepository.ObterPorIdAsync(id);
    }

    public async Task<Categoria> CriarCategoriaAsync(Categoria categoria)
    {
        return await _categoriaRepository.AdicionarAsync(categoria);
    }

    public async Task AtualizarCategoriaAsync(int id, Categoria categoria)
    {
        if (id != categoria.id)
        {
            // Lançar erro/exceção
            return;
        }
        await _categoriaRepository.AtualizarAsync(categoria);
    }

    public async Task DeletarCategoriaAsync(int id)
    {
        await _categoriaRepository.DeletarAsync(id);
    }
}

