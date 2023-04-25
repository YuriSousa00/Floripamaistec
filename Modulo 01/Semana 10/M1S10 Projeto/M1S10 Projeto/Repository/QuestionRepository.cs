using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;

namespace M1S10_Projeto.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ProjetoContext _context;

        public QuestionRepository(ProjetoContext context)
        {
            _context = context;
        }

        public void Adicionar(Question question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();



        }

        public List<Question> ObterLista()
        {
            return _context.Questions.ToList();

        }

        public Question ObterPorId(int id)
        {
            return _context.Questions.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Atualizar(Question question)
        {
            _context.Questions.Update(question);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var question = ObterPorId(id);

            _context.Questions.Remove(question);
            _context.SaveChanges();
        }


    }
}
