using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S09_ExercicioBercario.Models
{
    public class Mae
    {
        [Key]
        [Column("Mae")]
        [Required]
        public int Id { get; set; }
        [Column("Nome")]
        [StringLength(150)]
        [Required]
        public string Nome { get; set; }
        [Column("Endereco")]
        [StringLength(150)]
        [Required]
        public string Endereco { get; set; }
        [Column("Telefone")]
        [StringLength(16)]
        [Required]
        public string Telefone { get; set; }
        [Column("DataNascimento")]
        [Required]
        public DateTime DataNascimento { get; set; }

        public virtual ICollection<Bebe> Bebes { get; set; }

    }
}
