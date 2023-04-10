using Escola.Dto;
using Escola.Controllers;
using Escola.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Escola.Repository;

public class AlunoRepository
{
    private static List<AlunoModel> lista = new List<AlunoModel>()
    {
        new AlunoModel {Id = 1, Nome = "Carlos",},
        new AlunoModel {Id = 2, Nome = "Anderson"},
        new AlunoModel {Id = 3, Nome = "Silvana"},
    };

   public List<AlunoModel> ListarAlunos(string filtroNome)
    {
        if(string.IsNullOrEmpty(filtroNome))
            return lista;
        else
            return lista.Where(x => x.Nome.ToLower().Contains(filtroNome.ToLower()))
                .OrderBy(x => x.Id)
                .ToList();
            
    }
    public AlunoModel ObterAlunos(int id)
    {
        return lista.FirstOrDefault(x => x.Id == id);
    }
    public AlunoModel CriarAluno(AlunoModelDto dto)
    {
        var alunos = new AlunoModel();
        alunos.Id = GerarId();
        alunos.DataDeNascimento = dto.DataDeNascimento;
        alunos.Nome = dto.Nome;
        alunos.DataDeAlteracao = DateTime.Now;
        alunos.DataDeInclusao = DateTime.Now;

        lista.Add(alunos);

        return alunos;
    }
       private int GerarId()
    {
        return lista.Last().Id + 1;
    }
    public void ExcluirAluno(int Id)
    {
       var alunos = lista.FirstOrDefault(x => x.Id == Id);

       if (alunos != null)
       lista.Remove(alunos);
    }
}
