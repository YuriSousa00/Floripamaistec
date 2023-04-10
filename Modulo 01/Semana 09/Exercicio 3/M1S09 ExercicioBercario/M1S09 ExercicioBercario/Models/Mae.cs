using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S09_ExercicioBercario.Models
{
    public class Mae
    {
      
        public int Id { get; set; }
      
        public string Nome { get; set; }
        
        public string Endereco { get; set; }
        
        public string Telefone { get; set; }
        
        public DateTime DataNascimento { get; set; }

        public virtual ICollection<Bebe> Bebes { get; set; }

    }
}
