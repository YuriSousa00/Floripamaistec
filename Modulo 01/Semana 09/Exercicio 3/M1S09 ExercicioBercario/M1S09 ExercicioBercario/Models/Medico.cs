using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S09_ExercicioBercario.Models
{
    public class Medico
    {
        public int Id { get; set; }
    
        public string CRM { get; set; }
      
        public string Nome { get; set; }
    
        public string Celular { get; set; }
      
        public string Especialidade { get; set; }

        public virtual ICollection<Parto> Partos { get; set; }

    }
}
