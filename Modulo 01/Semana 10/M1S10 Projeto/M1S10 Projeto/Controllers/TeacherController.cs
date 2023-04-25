using M1S10_Projeto.Dto;
using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace M1S10_Projeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var teacher = _teacherRepository.ObterLista();

            return Ok(teacher);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {

            var teacher = _teacherRepository.ObterPorId(id);

            if (teacher == null)
                return NotFound();

            return Ok(teacher);

        }
        [HttpPost]
        public IActionResult Create([FromBody] TeacherCreateDto teacherDto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var teacher = new Teacher();

            teacher.Departament = teacherDto.Departament;
            teacher.IdUser = teacherDto.IdUser;           

            return Ok(teacher);

            var teacherReturnDto = new TeacherReturnDto();

            teacherReturnDto.IdUser = teacher.IdUser;
            teacherReturnDto.Departament = teacherDto.Departament;
           


            return CreatedAtAction(nameof(StudentController.Get), new { Id = teacher.Id }, teacherReturnDto);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] TeacherUpdateDto teacherDto)
        {

            var teacher = _teacherRepository.ObterPorId(id);

            teacher.Departament = teacherDto.Departament;

            var teacherReturnDto = new TeacherReturnDto();

            teacherReturnDto.IdUser = teacher.IdUser;
            teacherReturnDto.Departament = teacherDto.Departament;

            if (teacher == null)
                return NotFound();

            return CreatedAtAction(nameof(StudentController.Get), new { Id = teacher.Id }, teacherReturnDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {

            return NoContent();
        }


    }

}
