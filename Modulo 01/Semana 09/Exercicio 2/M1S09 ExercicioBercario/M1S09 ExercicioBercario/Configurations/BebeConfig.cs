using M1S09_ExercicioBercario.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace M1S09_ExercicioBercario.Configurations
{
    public class BebeConfig : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.ToTable("Bebe")
                .HasKey(e => e.Id);

            builder.HasOne(x => x.Mae)
                .WithMany(x => x.Bebes)
                .HasForeignKey(x => x.IdMae)
                .HasConstraintName("FK_Mae_Bebe");

            builder.ToTable("Parto")
                .HasKey(e => e.Id);

            builder.HasOne(x => x.Parto)
                .WithMany(x => x.Bebes)
                .HasForeignKey(x => x.IdParto)
                .HasConstraintName("FK_Parto_Bebe");
        }
    }
}
