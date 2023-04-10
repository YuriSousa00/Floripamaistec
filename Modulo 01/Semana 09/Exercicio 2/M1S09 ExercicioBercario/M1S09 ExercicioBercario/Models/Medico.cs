using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S09_ExercicioBercario.Models
{
    public class Medico
    {
        [Key]
        [Column("Medico")]
        [Required]
        public int Id { get; set; }
        [Column("CRM")]
        [StringLength(11)]
        [Required]
        public string CRM { get; set; }
        [Column("Nome")]
        [StringLength(150)]
        [Required]
        public string Nome { get; set; }
        [Column("Celular")]
        [StringLength(16)]
        [Required]
        public string Celular { get; set; }
        [Column("Especialidade")]
        [StringLength(150)]
        [Required]
        public string Especialidade { get; set; }

        public virtual ICollection<Parto> Partos { get; set; }

    }
}
