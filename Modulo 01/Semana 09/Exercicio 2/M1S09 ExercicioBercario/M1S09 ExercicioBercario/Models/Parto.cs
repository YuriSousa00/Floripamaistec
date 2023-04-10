using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace M1S09_ExercicioBercario.Models
{
    public class Parto
    {
        [Key]
        [Column("Parto")]
        [Required]
        public int Id { get; set; }
        [Column("HoraParto")]
        [Required]
        public DateTime HoraParto { get; set; }
        [Column("DataParto")]
        [Required]
        public DateTime DataParto { get; set; }
        [Column("Id_Medico")]
        [Required]
        public int IdMedico { get; set; }

        [ForeignKey("IdMedico")]
        public virtual Medico Medico { get; set; }
        public virtual ICollection<Bebe> Bebes { get; set; }

    }
}
