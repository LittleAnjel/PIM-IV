using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hortifruti.Controllers;

[ApiController]
[Route("api/[controller]")]

public class Unidade_medidaController : ControllerBase
{
    private readonly IUnidade_medidaService _unidade_medidaService;

    public Unidade_medidaController(IUnidade_medidaService unidade_medidaService)
    {
        _unidade_medidaService = unidade_medidaService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Unidade_medida>>> ObterUnidade_medida()
    {
        var unidade_medida = await _unidade_medidaService.ObterTodosUnidade_medidaAsync();
        return Ok(unidade_medida);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Unidade_medida>> ObterCategoria(int id)
    {
        var unidade_medida = await _unidade_medidaService.ObterUnidade_medidaPorIdAsync(id);

        if (unidade_medida == null) return NotFound();
        return Ok(unidade_medida);
    }

    [HttpPost]
    public async Task<ActionResult<Unidade_medida>> CriarUnidade_medida(Unidade_medida unidade_medida)
    {
        var unidade_medidaCriado = await _unidade_medidaService.CriarUnidade_medidaAsync(unidade_medida);
        return CreatedAtAction(nameof(ObterCategoria), new { unidade_medidaCriado.Id },
            unidade_medidaCriado);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarUnidade_medida(int id, Unidade_medida unidade_medida)
    {
        if (id != unidade_medida.Id) return BadRequest();
        await _unidade_medidaService.AtualizarUnidade_medidaAsync(id, unidade_medida);
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarUnidade_medida(int id) 
    { 
        await _unidade_medidaService.DeletarUnidade_medidaAsync(id); 
        return NoContent(); 
    }
}