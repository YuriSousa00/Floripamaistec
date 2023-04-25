using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S10_Projeto.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }
        public int IdQuiz { get; set; }


    }
}
