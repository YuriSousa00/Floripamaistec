using M1S10_Projeto.Models;

namespace M1S10_Projeto.Repository.Interfaces
{
    public interface IStudentRepository
    {
        void Adicionar(Student student);
        List<Student> ObterLista();
        Student ObterPorId(int id);
        void Atualizar(Student student);    
        void Excluir(int id);
    }
}
