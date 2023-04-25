using M1S10_Projeto.Dto;
using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace M1S10_Projeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Student_DisciplineController : ControllerBase
    {
        private readonly IStudent_DisciplineRepository _student_DisciplineRepository;
        public Student_DisciplineController(IStudent_DisciplineRepository student_DisciplineRepository)
        {
            _student_DisciplineRepository = student_DisciplineRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var student_Discipline = _student_DisciplineRepository.ObterLista();

            return Ok(student_Discipline);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {

            var student_Discipline = _student_DisciplineRepository.ObterPorId(id);

            if (student_Discipline == null)
                return NotFound();

            return Ok(student_Discipline);

        }
        [HttpPost]
        public IActionResult Create([FromBody] Student_DisciplineCreateDto student_DisciplineDto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var student_Discipline = new Student_Discipline();

            student_Discipline.IdStudent = student_DisciplineDto.IdStudent;
            student_Discipline.IdDiscipline = student_DisciplineDto.IdDiscipline;
            
            return Ok(student_Discipline);

            var student_DisciplineReturnDto = new Student_DisciplineReturnDto();

            student_DisciplineReturnDto.Id = student_Discipline.Id;
            student_DisciplineReturnDto.IdStudent = student_DisciplineDto.IdStudent;
            student_DisciplineReturnDto.IdDiscipline = student_DisciplineDto.IdDiscipline;
            


            return CreatedAtAction(nameof(StudentController.Get), new { Id = student_Discipline.Id }, student_DisciplineReturnDto);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] Student_DisciplineUpdateDto student_DisciplineDto)
        {

            var student_Discipline = _student_DisciplineRepository.ObterPorId(id);

            student_Discipline.IdDiscipline = student_DisciplineDto.IdDiscipline;
            
            var student_DisciplineReturnDto = new Student_DisciplineReturnDto();

            student_DisciplineReturnDto.Id = student_Discipline.Id;
            student_DisciplineReturnDto.IdDiscipline = student_DisciplineDto.IdDiscipline;
            student_DisciplineReturnDto.IdStudent = student_Discipline.IdStudent;
            

            if (student_Discipline == null)
                return NotFound();

            return CreatedAtAction(nameof(StudentController.Get), new { Id = student_Discipline.Id }, student_DisciplineReturnDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {

            return NoContent();
        }


    }

}
