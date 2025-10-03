using Hortifruti.Data.Repository;
using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hortifruti.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PermissaoController : ControllerBase
{
    private readonly IPermissaoService _permissaoService;

    public PermissaoController(IPermissaoService permissaoService)
    {
        _permissaoService = permissaoService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Permissao>>> ObterPermissaos()
    {
        var permissao = await _permissaoService.ObterTodasPermissaosAsync();
        return Ok(permissao);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Permissao>> ObterPermissao(int id)
    {
        var permissao = await _permissaoService.ObterPermissaoPorIdAsync(id);

        if (permissao == null) return NotFound();
        return Ok(permissao);
    }

    [HttpPost]
    public async Task<ActionResult<Permissao>> CriarPermissao(Permissao permissao)
    {
        var permissaoCriada = await _permissaoService.CriarPermissaoAsync(permissao);
        return CreatedAtAction(nameof(ObterPermissao), new { id = permissaoCriada.Id },
            permissaoCriada);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarPermissao(int id, Permissao permissao)
    {
        if (id != permissao.Id) return BadRequest();
        await _permissaoService.AtualizarPermissaoAsync(id, permissao);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarPermissao(int id) 
    { 
        await _permissaoService.DeletarPermissaoAsync(id); 
        return NoContent(); 
    } 
}