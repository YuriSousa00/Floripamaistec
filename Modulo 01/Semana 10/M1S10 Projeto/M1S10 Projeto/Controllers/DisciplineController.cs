using M1S10_Projeto.Dto;
using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace M1S10_Projeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplineController : ControllerBase
    {
        private readonly IDisciplineRepository _diciplineRepository;
        public DisciplineController(IDisciplineRepository diciplineRepository)
        {
            _diciplineRepository = diciplineRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var dicipline = _diciplineRepository.ObterLista();

            return Ok(dicipline);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {

            var dicipline = _diciplineRepository.ObterPorId(id);

            if (dicipline == null)
                return NotFound();

            return Ok(dicipline);

        }
        [HttpPost]
        public IActionResult Create([FromBody] DisciplineCreateDto disciplineDto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var discipline = new Discipline();

            discipline.Disciplines = disciplineDto.Disciplines;
            discipline.IdTeacher = disciplineDto.IdTeacher;

            return Ok(discipline);

            var disciplineReturnDto = new DisciplineReturnDto();

            disciplineReturnDto.Id = discipline.Id;
            disciplineReturnDto.Disciplines = disciplineDto.Disciplines;
            disciplineReturnDto.IdTeacher = discipline.IdTeacher;
            


            return CreatedAtAction(nameof(StudentController.Get), new { Id = discipline.Id }, disciplineReturnDto);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] DisciplineUpdateDto disciplineDto)
        {

            var discipline = _diciplineRepository.ObterPorId(id);

            discipline.Disciplines = disciplineDto.Disciplines;

            return Ok(discipline);

            var disciplineReturnDto = new DisciplineReturnDto();

            disciplineReturnDto.Id = discipline.Id;
            disciplineReturnDto.Disciplines = disciplineDto.Disciplines;
            disciplineReturnDto.IdTeacher = discipline.IdTeacher;

            if (discipline == null)
                return NotFound();

            return CreatedAtAction(nameof(StudentController.Get), new { Id = discipline.Id }, disciplineReturnDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {

            return NoContent();
        }


    }

}
