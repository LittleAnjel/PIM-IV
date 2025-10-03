using Hortifruti.Data.Repository;
using Hortifruti.Domain;
using Hortifruti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hortifruti.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CargoController : ControllerBase
{
    private readonly ICargoService _cargoService;

    public CargoController(ICargoService cargoService)
    {
        _cargoService = cargoService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cargo>>> ObterCargos()
    {
        var cargo = await _cargoService.ObterTodasCargosAsync();
        return Ok(cargo);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Cargo>> ObterCargo(int id)
    {
        var cargo = await _cargoService.ObterCargoPorIdAsync(id);

        if (cargo == null) return NotFound();
        return Ok(cargo);
    }

    [HttpPost]
    public async Task<ActionResult<Cargo>> CriarCargo(Cargo cargo)
    {
        var cargoCriada = await _cargoService.CriarCargoAsync(cargo);
        return CreatedAtAction(nameof(ObterCargo), new { id = cargoCriada.Id },
            cargoCriada);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarCargo(int id, Cargo cargo)
    {
        if (id != cargo.Id) return BadRequest();
        await _cargoService.AtualizarCargoAsync(id, cargo);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarCargo(int id) 
    { 
        await _cargoService.DeletarCargoAsync(id); 
        return NoContent(); 
    } 
}