using Hortifruti.Data.Repository;
using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hortifruti.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ModuloController : ControllerBase
{
    private readonly IModuloService _moduloService;

    public ModuloController(IModuloService moduloService)
    {
        _moduloService = moduloService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Modulo>>> ObterModulos()
    {
        var modulo = await _moduloService.ObterTodasModulosAsync();
        return Ok(modulo);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Modulo>> ObterModulo(int id)
    {
        var modulo = await _moduloService.ObterModuloPorIdAsync(id);

        if (modulo == null) return NotFound();
        return Ok(modulo);
    }

    [HttpPost]
    public async Task<ActionResult<Modulo>> CriarModulo(Modulo modulo)
    {
        var moduloCriada = await _moduloService.CriarModuloAsync(modulo);
        return CreatedAtAction(nameof(ObterModulo), new { id = moduloCriada.Id },
            moduloCriada);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarModulo(int id, Modulo modulo)
    {
        if (id != modulo.Id) return BadRequest();
        await _moduloService.AtualizarModuloAsync(id, modulo);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarModulo(int id) 
    { 
        await _moduloService.DeletarModuloAsync(id); 
        return NoContent(); 
    } 
}