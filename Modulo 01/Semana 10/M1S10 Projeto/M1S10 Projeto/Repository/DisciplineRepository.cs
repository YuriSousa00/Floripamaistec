using M1S10_Projeto.Models;
using M1S10_Projeto.Repository.Interfaces;

namespace M1S10_Projeto.Repository
{
    public class DisciplineRepository : IDisciplineRepository
    {
        private readonly ProjetoContext _context;

        public DisciplineRepository(ProjetoContext context)
        {
            _context = context;
        }

        public void Adicionar(Discipline discipline)
        {
            _context.Disciplines.Add(discipline);
            _context.SaveChanges();



        }

        public List<Discipline> ObterLista()
        {
            return _context.Disciplines.ToList();

        }

        public Discipline ObterPorId(int id)
        {
            return _context.Disciplines.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Atualizar(Discipline discipline)
        {
            _context.Disciplines.Update(discipline);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var discipline = ObterPorId(id);

            _context.Disciplines.Remove(discipline);
            _context.SaveChanges();
        }


    }
}
