using M1S10_Projeto.Models;

namespace M1S10_Projeto.Repository.Interfaces
{
    public interface IAnswerRepository
    {
        void Adicionar(Answer answer);
        List<Answer> ObterLista();
        Answer ObterPorId(int id);
        void Atualizar(Answer answer);
        void Excluir(int id);
    }
}
