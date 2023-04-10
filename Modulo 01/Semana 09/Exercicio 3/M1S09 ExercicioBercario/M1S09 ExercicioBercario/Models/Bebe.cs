using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S09_ExercicioBercario.Models
{
    public class Bebe
    {
        
        public int Id { get; set; }
       
        public DateTime DataNascimento { get; set; }
        
        public decimal PesoNascimento { get; set; }
        
        public decimal Altura { get; set; }
        
        public int IdMae { get; set; }
        
        public int IdParto { get; set; }

        public virtual Mae Mae { get; set; }
        
        public virtual Parto Parto { get; set; }

    }
}
