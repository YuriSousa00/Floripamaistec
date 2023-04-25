using System.Net.Http;
using M1S10_Projeto.Dto;
using M1S10_Projeto.Models;
using M1S10_Projeto.Repository;
using M1S10_Projeto.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace M1S10_Projeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository; 
        }

        [HttpGet]
        public IActionResult Get()
        {
            
            var student = _studentRepository.ObterLista();

            return Ok(student);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {

            var student = _studentRepository.ObterPorId(id);

            if (student == null)
                return NotFound();

            return Ok(student);

        }
        [HttpPost]
        public IActionResult Create([FromBody] StudentCreateDto studentDto)
        {
            if(ModelState.IsValid == false) 
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var student = new Student();

            student.Name = studentDto.Name;
            student.Email = studentDto.Email;
            student.CPF = studentDto.CPF;
            student.Password = studentDto.Password;

            return Ok(student);

            var studentReturnDto = new StudentReturnDto();

            studentReturnDto.Id = student.Id;
            studentReturnDto.Name = studentDto.Name;
            studentReturnDto.Email = studentDto.Email;
            studentReturnDto.CPF = studentDto.CPF;
            studentReturnDto.Password = studentDto.Password;
            studentReturnDto.RA = student.RA;


            return CreatedAtAction(nameof(StudentController.Get), new { Id = student.Id }, studentReturnDto);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] StudentUpdateDto studentDto)
        {

            var student = _studentRepository.ObterPorId(id);
    
            student.Name = studentDto.Name;
            student.Email = studentDto.Email;
            student.CPF = studentDto.CPF;
            student.Password = studentDto.Password;

            var studentReturnDto = new StudentReturnDto();
            
            studentReturnDto.Id = student.Id;
            studentReturnDto.Name = studentDto.Name;
            studentReturnDto.Email = studentDto.Email;
            studentReturnDto.CPF = studentDto.CPF;
            studentReturnDto.Password = studentDto.Password;
            studentReturnDto.RA = student.RA;

            if (student == null)
            return NotFound();

            return CreatedAtAction(nameof(StudentController.Get), new { Id = student.Id },  studentReturnDto);
        }
        
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
                
            return NoContent();
        }
       
        
    }
    
     
}
