using M1S10_Projeto.Models;

namespace M1S10_Projeto.Repository.Interfaces
{
    public interface IDisciplineRepository
    {
        void Adicionar(Discipline discipline);
        List<Discipline> ObterLista();
        Discipline ObterPorId(int id);
        void Atualizar(Discipline discipline);
        void Excluir(int id);
    }
}
