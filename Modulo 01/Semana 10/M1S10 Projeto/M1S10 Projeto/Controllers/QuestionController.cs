using M1S10_Projeto.Dto;
using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace M1S10_Projeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;
        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var question = _questionRepository.ObterLista();

            return Ok(question);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {

            var question = _questionRepository.ObterPorId(id);

            if (question == null)
                return NotFound();

            return Ok(question);

        }
        [HttpPost]
        public IActionResult Create([FromBody] QuestionCreateDto questionDto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var question = new Question();

            question.IdQuiz = questionDto.IdQuiz;
            question.Enunciation = questionDto.Enunciation;
            question.Weight = questionDto.Weight;

            return Ok(question);

            var questionReturnDto = new QuestionReturnDto();

            questionReturnDto.Id = question.Id;
            questionReturnDto.Enunciation = questionDto.Enunciation;
            questionReturnDto.Weight = questionDto.Weight;
            questionReturnDto.IdQuiz = questionDto.IdQuiz;
          

            return CreatedAtAction(nameof(StudentController.Get), new { Id = question.Id }, questionReturnDto);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] QuestionUpdateDto questionDto)
        {

            var question = _questionRepository.ObterPorId(id);

            question.Enunciation = questionDto.Enunciation;
            question.Weight = questionDto.Weight;

            var questionReturnDto = new QuestionReturnDto();

            questionReturnDto.Id = question.Id;
            questionReturnDto.Enunciation = questionDto.Enunciation;
            questionReturnDto.Weight = questionDto.Weight;
            questionReturnDto.IdQuiz = question.IdQuiz;

            if (question == null)
                return NotFound();

            return CreatedAtAction(nameof(StudentController.Get), new { Id = question.Id }, questionReturnDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {

            return NoContent();
        }


    }

}
