using Hortifruti.Data.Repository;
using Hortifruti.Domain;
using Hortifruti.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hortifruti.Controllers;

[ApiController]
[Route("api/[controller]")]

public class Fornecedor_produtoController : ControllerBase
{
    private readonly IFornecedor_produtoService _fornecedor_produtoService;

    public Fornecedor_produtoController(IFornecedor_produtoService fornecedor_produtoService)
    {
        _fornecedor_produtoService = fornecedor_produtoService;
    }

    // Endpoint de consulta de todos os registro da tabela
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Fornecedor_produto>>> ObterFornecedor_produtos()
    {
        var fornecedor_produto = await _fornecedor_produtoService.ObterTodasFornecedor_produtosAsync();
        return Ok(fornecedor_produto);
    }

    // Endpoint de consulta por ID
    [HttpGet("{fornecedorId}/{produtoId}")]
    public async Task<ActionResult<Fornecedor_produto>> ObterFornecedor_produto(int fornecedorId, int produtoId)
    {
        var fornecedor_produto = await _fornecedor_produtoService.ObterFornecedor_produtoPorIdAsync(fornecedorId, produtoId);

        if (fornecedor_produto == null) return NotFound();
        return Ok(fornecedor_produto);
    }

    // Endpoint de criação do registro na tabela
    [HttpPost]
    public async Task<ActionResult<Fornecedor_produto>> CriarFornecedor_produto(Fornecedor_produto fornecedor_produto)
    {
        var fornecedor_produtoCriada = await _fornecedor_produtoService.CriarFornecedor_produtoAsync(fornecedor_produto);

        return CreatedAtAction(nameof(ObterFornecedor_produto), new { fornecedorId = fornecedor_produto.FornecedorId, produtoId = fornecedor_produto.ProdutoId },
            fornecedor_produtoCriada);
    }

    // Endpoint de alteração de algum registro na tabela
    [HttpPut("{fornecedorId}/{produtoId}")] 
    public async Task<IActionResult> AtualizarFornecedor_produto(int fornecedorId, int produtoId, Fornecedor_produto fornecedor_produto)
    {
        if (fornecedorId != fornecedor_produto.FornecedorId || produtoId != fornecedor_produto.ProdutoId) return BadRequest();

        await _fornecedor_produtoService.AtualizarFornecedor_produtoAsync(fornecedorId, produtoId, fornecedor_produto);
        return NoContent();
    }

    // Endpoint de exclusão de algum registro na tabela
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarFornecedor_produto(int fornecedorId, int produtoId)
    {
        await _fornecedor_produtoService.DeletarFornecedor_produtoAsync(fornecedorId, produtoId);
        return NoContent();
    } 
}