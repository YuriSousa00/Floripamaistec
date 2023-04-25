using M1S10_Projeto.Models;

namespace M1S10_Projeto.Repository.Interfaces
{
    public interface IQuizRepository
    {
        void Adicionar(Quiz quiz);
        List<Quiz> ObterLista();
        Quiz ObterPorId(int id);
        void Atualizar(Quiz quiz);
        void Excluir(int id);
    }
}
