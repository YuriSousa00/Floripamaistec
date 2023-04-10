using M1S09_ExercicioBercario.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace M1S09_ExercicioBercario.Configurations
{
    public class PartoConfig : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Parto");
            builder.Property(e => e.IdMedico)
                .HasColumnName("Id_Medico");


            builder.HasOne(x => x.Medico)
                .WithMany(x => x.Partos)
                .HasForeignKey(x => x.IdMedico)
                .HasConstraintName("FK_Parto_Medico");

            builder.ToTable("Parto");

        }
    }
}
