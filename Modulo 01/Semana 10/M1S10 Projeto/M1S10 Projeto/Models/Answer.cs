using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace M1S10_Projeto.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Answers { get; set; }
        public float Score { get; set; }
        public string Observation { get; set; }
        public int IdQuestion { get; set; }
        public int IdStudent { get; set; }

    }
}
