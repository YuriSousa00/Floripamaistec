using M1S10_Projeto.Models;

namespace M1S10_Projeto.Repository.Interfaces
{
    public interface ITeacherRepository
    {
        void Adicionar(Teacher teacher);
        List<Teacher> ObterLista();
        Teacher ObterPorId(int id);
        void Atualizar(Teacher teacher);
        void Excluir(int id);
    }
}
