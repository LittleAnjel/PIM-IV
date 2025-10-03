using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hortifruti.Controllers;

[ApiController]
[Route("api/[controller]")]

public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioService _funcionarioService;

    public FuncionarioController(IFuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Funcionario>>> ObterFuncionario()
    {
        var funcionario = await _funcionarioService.ObterTodosFuncionarioAsync();
        return Ok(funcionario);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Funcionario>> ObterCategoria(int id)
    {
        var funcionario = await _funcionarioService.ObterFuncionarioPorIdAsync(id);

        if (funcionario == null) return NotFound();
        return Ok(funcionario);
    }

    [HttpPost]
    public async Task<ActionResult<Funcionario>> CriarFuncionario(Funcionario funcionario)
    {
        var funcionarioCriado = await _funcionarioService.CriarFuncionarioAsync(funcionario);
        return CreatedAtAction(nameof(ObterCategoria), new { funcionarioCriado.Id },
            funcionarioCriado);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarFuncionario(int id, Funcionario funcionario)
    {
        if (id != funcionario.Id) return BadRequest();
        await _funcionarioService.AtualizarFuncionarioAsync(id, funcionario);
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarFuncionario(int id) 
    { 
        await _funcionarioService.DeletarFuncionarioAsync(id); 
        return NoContent(); 
    }
}