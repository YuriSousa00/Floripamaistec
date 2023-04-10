using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace M1S09_ExercicioBercario.Models
{
    public class Parto
    {
        
        public int Id { get; set; }
        public DateTime HoraParto { get; set; }
        public DateTime DataParto { get; set; }
        public int IdMedico { get; set; }

  
        public virtual Medico Medico { get; set; }
        public virtual ICollection<Bebe> Bebes { get; set; }

    }
}
