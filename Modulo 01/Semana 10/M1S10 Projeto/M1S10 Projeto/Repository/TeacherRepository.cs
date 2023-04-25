using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;

namespace M1S10_Projeto.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ProjetoContext _context;

        public TeacherRepository(ProjetoContext context)
        {
            _context = context;
        }

        public void Adicionar(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();



        }

        public List<Teacher> ObterLista()
        {
            return _context.Teachers.ToList();

        }

        public Teacher ObterPorId(int id)
        {
            return _context.Teachers.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Atualizar(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var teacher = ObterPorId(id);

            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
        }


    }
}
