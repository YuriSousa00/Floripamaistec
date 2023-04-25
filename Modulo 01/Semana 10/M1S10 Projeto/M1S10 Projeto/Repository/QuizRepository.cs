using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;

namespace M1S10_Projeto.Repository
{
    public class QuizRepository : IQuizRepository
    {
        private readonly ProjetoContext _context;

        public QuizRepository(ProjetoContext context)
        {
            _context = context;
        }

        public void Adicionar(Quiz quiz)
        {
            _context.Quizzes.Add(quiz);
            _context.SaveChanges();



        }

        public List<Quiz> ObterLista()
        {
            return _context.Quizzes.ToList();

        }

        public Quiz ObterPorId(int id)
        {
            return _context.Quizzes.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Atualizar(Quiz quiz)
        {
            _context.Quizzes.Update(quiz);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var quiz = ObterPorId(id);

            _context.Quizzes.Remove(quiz);
            _context.SaveChanges();
        }


    }
}
