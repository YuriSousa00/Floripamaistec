using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;

namespace M1S10_Projeto.Repository
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly ProjetoContext _context;

        public AnswerRepository(ProjetoContext context)
        {
            _context = context;
        }

        public void Adicionar(Answer answer)
        {
            _context.Answers.Add(answer);
            _context.SaveChanges();



        }

        public List<Answer> ObterLista()
        {
            return _context.Answers.ToList();

        }

        public Answer ObterPorId(int id)
        {
            return _context.Answers.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Atualizar(Answer answer)
        {
            _context.Answers.Update(answer);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var answer = ObterPorId(id);

            _context.Answers.Remove(answer);
            _context.SaveChanges();
        }


    }
}
