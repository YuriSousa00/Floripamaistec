using Escola.Dto;
using Escola.Models;
using Escola.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers;


[ApiController]
[Route("[Controller]")]
public class AlunoController : ControllerBase
{
    [HttpGet]
    public IActionResult Listar(string? nome)
    {
        var repository = new AlunoRepository();
        var alunos = repository.ListarAlunos(nome);

        return Ok(alunos);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Obter(int id)
    {
        if (id <= 0) 
            return BadRequest("Id deve ser maior que zero");

        var repository = new AlunoRepository();
        var alunos = repository.ObterAlunos(id);

        if (alunos == null)
            return NotFound(alunos);

            return Ok(alunos);
    }
    [HttpPost]
    public IActionResult Criar([FromBody] AlunoModelDto dto)
    {
        var repository = new AlunoRepository();
        var alunos = repository.CriarAluno(dto);

        return CreatedAtAction(nameof(AlunoController.Obter), new {Id = alunos.Id}, alunos);
    }  

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Excluir(int id)
    {
        var repository = new AlunoRepository();
        repository.ExcluirAluno(id);

        return NoContent();
    }
}

