using M1S10_Projeto.Models;

namespace M1S10_Projeto.Repository.Interfaces
{
    public interface IStudent_DisciplineRepository
    {
        void Adicionar(Student_Discipline student_Discipline);
        List<Student_Discipline> ObterLista();
        Student_Discipline ObterPorId(int id);
        void Atualizar(Student_Discipline student_Discipline);
        void Excluir(int id);
    }
}
