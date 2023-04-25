using M1S10_Projeto.Models;

namespace M1S10_Projeto.Repository.Interfaces
{
    public interface IQuestionRepository
    {
        void Adicionar(Question question);
        List<Question> ObterLista();
        Question ObterPorId(int id);
        void Atualizar(Question question);
        void Excluir(int id);
    }
}
