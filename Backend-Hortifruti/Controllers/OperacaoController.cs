using Hortifruti.Data.Repository;
using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hortifruti.Controllers;

[ApiController]
[Route("api/[controller]")]

public class OperacaoController : ControllerBase
{
    private readonly IOperacaoService _operacaoService;

    public OperacaoController(IOperacaoService operacaoService)
    {
        _operacaoService = operacaoService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Operacao>>> ObterOperacaos()
    {
        var operacao = await _operacaoService.ObterTodasOperacaosAsync();
        return Ok(operacao);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Operacao>> ObterOperacao(int id)
    {
        var operacao = await _operacaoService.ObterOperacaoPorIdAsync(id);

        if (operacao == null) return NotFound();
        return Ok(operacao);
    }

    [HttpPost]
    public async Task<ActionResult<Operacao>> CriarOperacao(Operacao operacao)
    {
        var operacaoCriada = await _operacaoService.CriarOperacaoAsync(operacao);
        return CreatedAtAction(nameof(ObterOperacao), new { id = operacaoCriada.Id },
            operacaoCriada);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarOperacao(int id, Operacao operacao)
    {
        if (id != operacao.Id) return BadRequest();
        await _operacaoService.AtualizarOperacaoAsync(id, operacao);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarOperacao(int id) 
    { 
        await _operacaoService.DeletarOperacaoAsync(id); 
        return NoContent(); 
    } 
}