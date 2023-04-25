using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;

namespace M1S10_Projeto.Repository
{
    public class Student_DisciplineRepository : IStudent_DisciplineRepository
    {
        private readonly ProjetoContext _context;

        public Student_DisciplineRepository(ProjetoContext context)
        {
            _context = context;
        }

        public void Adicionar(Student_Discipline student_Discipline)
        {
            _context.StudentDisciplines.Add(student_Discipline);
            _context.SaveChanges();



        }

        public List<Student_Discipline> ObterLista()
        {
            return _context.StudentDisciplines.ToList();

        }

        public Student_Discipline ObterPorId(int id)
        {
            return _context.StudentDisciplines.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Atualizar(Student_Discipline student_Discipline)
        {
            _context.StudentDisciplines.Update(student_Discipline);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var student_Discipline = ObterPorId(id);

            _context.StudentDisciplines.Remove(student_Discipline);
            _context.SaveChanges();
        }


    }
}
