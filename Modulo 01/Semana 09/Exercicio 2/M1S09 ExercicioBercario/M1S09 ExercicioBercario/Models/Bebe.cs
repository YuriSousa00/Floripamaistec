using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S09_ExercicioBercario.Models
{
    public class Bebe
    {
        [Key]
        [Column("Bebe")]
        [Required]
        public int Id { get; set; }
        [Column("DataNascimento")]
        [Required]
        public DateTime DataNascimento { get; set; }
        [Column("PesoNascimento", TypeName="decimal(1,3)")]
        [Required]
        public decimal PesoNascimento { get; set; }
        [Column("Altura", TypeName = "decimal(2,2)")]
        [Required]
        public decimal Altura { get; set; }
        [Column("Id_Mae")]
        [Required]
        public int IdMae { get; set; }
        [Column("Id_Parto")]
        [Required]
        public int IdParto { get; set; }

        [ForeignKey("IdMae")]
        public virtual Mae Mae { get; set; }
        [ForeignKey("IdParto")]
        public virtual Parto Parto { get; set; }

    }
}
