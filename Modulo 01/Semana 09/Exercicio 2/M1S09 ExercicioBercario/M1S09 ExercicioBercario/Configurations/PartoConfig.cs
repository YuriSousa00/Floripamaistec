using M1S09_ExercicioBercario.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace M1S09_ExercicioBercario.Configurations
{
    public class PartoConfig : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.ToTable("Parto")
                .HasKey(e => e.Id);

            builder.HasOne(x => x.Medico)
                .WithMany(x => x.Partos)
                .HasForeignKey(x => x.IdMedico)
                .HasConstraintName("FK_Parto_Medico");

        }
    }
}
