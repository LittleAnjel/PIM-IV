using Hortifruti.Data.Repository;
using Hortifruti.Domain;
using Hortifruti.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hortifruti.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProdutoController : ControllerBase
{
    private readonly IProdutoService _produtoService;

    public ProdutoController(IProdutoService produtoService)
    {
        _produtoService = produtoService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Produto>>> ObterProdutos()
    {
        var produto = await _produtoService.ObterTodasProdutosAsync();
        return Ok(produto);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Produto>> ObterProduto(int id)
    {
        var produto = await _produtoService.ObterProdutoPorIdAsync(id);

        if (produto == null) return NotFound();
        return Ok(produto);
    }

    [HttpPost]
    public async Task<ActionResult<Produto>> CriarProduto(Produto produto)
    {
        var produtoCriada = await _produtoService.CriarProdutoAsync(produto);
        return CreatedAtAction(nameof(ObterProduto), new { id = produtoCriada.Id },
            produtoCriada);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarProduto(int id, Produto produto)
    {
        if (id != produto.Id) return BadRequest();
        await _produtoService.AtualizarProdutoAsync(id, produto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarProduto(int id) 
    { 
        await _produtoService.DeletarProdutoAsync(id); 
        return NoContent(); 
    } 
}