using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hortifruti.Controllers;

[ApiController]
[Route("api/[controller]")]

public class FornecedorController : ControllerBase
{
    private readonly IFornecedorService _fornecedorService;

    public FornecedorController(IFornecedorService fornecedorService)
    {
        _fornecedorService = fornecedorService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Fornecedor>>> ObterFornecedor()
    {
        var fornecedor = await _fornecedorService.ObterTodosFornecedoresAsync();
        return Ok(fornecedor);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Fornecedor>> ObterCategoria(int id)
    {
        var fornecedor = await _fornecedorService.ObterFornecedorPorIdAsync(id);

        if (fornecedor == null) return NotFound();
        return Ok(fornecedor);
    }

    [HttpPost]
    public async Task<ActionResult<Fornecedor>> CriarFornecedor(Fornecedor fornecedor)
    {
        var fornecedorCriado = await _fornecedorService.CriarFornecedorAsync(fornecedor);
        return CreatedAtAction(nameof(ObterCategoria), new { fornecedorCriado.Id },
            fornecedorCriado);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarFornecedor(int id, Fornecedor fornecedor)
    {
        if (id != fornecedor.Id) return BadRequest();
        await _fornecedorService.AtualizarFornecedorAsync(id, fornecedor);
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarFornecedor(int id) 
    { 
        await _fornecedorService.DeletarFornecedorAsync(id); 
        return NoContent(); 
    }
}