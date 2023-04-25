using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S10_Projeto.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Disciplines { get; set; }
        public int IdTeacher { get; set; }

    }   
}
