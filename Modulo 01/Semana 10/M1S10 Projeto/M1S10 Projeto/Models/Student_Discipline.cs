using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S10_Projeto.Models
{
    public class Student_Discipline
    {
        public int Id { get; set; }
        public int IdStudent { get; set; }
        public int IdDiscipline { get; set; }


    }
}
