using M1S10_Projeto.Dto;
using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace M1S10_Projeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerRepository _answerRepository;
        public AnswerController(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var answer = _answerRepository.ObterLista();

            return Ok(answer);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {

            var answer = _answerRepository.ObterPorId(id);

            if (answer == null)
                return NotFound();

            return Ok(answer);

        }
        [HttpPost]
        public IActionResult Create([FromBody] AnswerCreateDto answerDto) 
        { 
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var answer = new Answer();

            answer.Answers = answerDto.Answers;
            answer.Score = answerDto.Score;
            answer.Observation = answerDto.Observation;
            
            return Ok(answer);

            var answerReturnDto = new AnswerReturnDto();

            answerReturnDto.Id = answer.Id;
            answerReturnDto.Score = answer.Score;
            answerReturnDto.Observation = answer.Observation;
            answerReturnDto.Answers = answer.Answers;
            answerReturnDto.IdStudent = answer.IdStudent;
            answerReturnDto.IdQuestion = answer.IdQuestion;


            return CreatedAtAction(nameof(StudentController.Get), new { Id = answer.Id }, answerReturnDto);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] AnswerUpdateDto answerDto)
        {

            var answer = _answerRepository.ObterPorId(id);

            answer.Answers = answerDto.Answers;
            answer.Observation = answer.Observation;
            answer.Score = answerDto.Score;

            var answerReturnDto = new AnswerReturnDto();

            answerReturnDto.Id = answer.Id;
            answerReturnDto.Answers = answerDto.Answers;
            answerReturnDto.Observation = answerDto.Observation;
            answerReturnDto.Score = answerDto.Score;
            answerReturnDto.IdStudent = answer.IdStudent;
            answerReturnDto.IdQuestion = answer.IdQuestion;

            if (answer == null)
                return NotFound();

            return CreatedAtAction(nameof(StudentController.Get), new { Id = answer.Id }, answerReturnDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {

            return NoContent();
        }


    }

}
