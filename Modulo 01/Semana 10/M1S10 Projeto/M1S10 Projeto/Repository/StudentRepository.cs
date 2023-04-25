using M1S10_Projeto.Dto;
using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;

namespace M1S10_Projeto.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ProjetoContext _context;

        public StudentRepository(ProjetoContext context)
        {
            _context = context;
        }

        public void Adicionar(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();



        }

        public List<Student> ObterLista()
        {
            return _context.Students.ToList();
            
        }

        public Student ObterPorId(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Atualizar(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var student = ObterPorId(id);

            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        
    }
}
