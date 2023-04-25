using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S10_Projeto.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime DateClose { get; set; }
        public int IdDiscipline { get; set; }

    }
}
