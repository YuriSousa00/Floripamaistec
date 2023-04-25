using M1S10_Projeto.Dto;
using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace M1S10_Projeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizController : ControllerBase
    {
        private readonly IQuizRepository _quizRepository;
        public QuizController(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var quiz = _quizRepository.ObterLista();

            return Ok(quiz);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {

            var quiz = _quizRepository.ObterPorId(id);

            if (quiz == null)
                return NotFound();

            return Ok(quiz);

        }
        [HttpPost]
        public IActionResult Create([FromBody] QuizCreateDto quizDto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var quiz = new Quiz();

            quiz.Title = quizDto.Title;
            quiz.IdDiscipline = quizDto.IdDiscipline;
           

            return Ok(quiz);

            var quizReturnDto = new QuizReturnDto();

            quizReturnDto.Id = quiz.Id;
            quizReturnDto.IdDiscipline = quizDto.IdDiscipline;
            quizReturnDto.Title = quizDto.Title;
            quizReturnDto.DateClose = quiz.DateClose;
            quizReturnDto.DateOpen = quiz.DateOpen;
            


            return CreatedAtAction(nameof(StudentController.Get), new { Id = quiz.Id }, quizReturnDto);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] QuizUpdateDto quizDto)
        {

            var quiz = _quizRepository.ObterPorId(id);

            quiz.Title = quiz.Title;
            

            var quizReturnDto = new QuizReturnDto();

            quizReturnDto.Id = quiz.Id;
            quizReturnDto.IdDiscipline = quiz.IdDiscipline;
            quizReturnDto.Title = quizDto.Title;
            quizReturnDto.DateClose = quiz.DateClose;
            quizReturnDto.DateOpen = quiz.DateOpen;

            if (quiz == null)
                return NotFound();

            return CreatedAtAction(nameof(StudentController.Get), new { Id = quiz.Id }, quizReturnDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {

            return NoContent();
        }


    }

}
