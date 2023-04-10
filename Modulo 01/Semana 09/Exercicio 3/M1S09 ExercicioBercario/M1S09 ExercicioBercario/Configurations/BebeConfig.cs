using M1S09_ExercicioBercario.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace M1S09_ExercicioBercario.Configurations
{
    public class BebeConfig : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.PesoNascimento)
        .HasColumnType("decimal(18,2)");

            builder.Property(b => b.Altura)
        .HasColumnType("decimal(18,2)");

            builder.Property(p => p.IdMae)
                .HasColumnName("Id_Mae");

            builder.Property(p => p.IdParto)
                .HasColumnName("Id_Parto");

            builder.HasOne(x => x.Mae)
                .WithMany(x => x.Bebes)
                .HasForeignKey(x => x.IdMae)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mae_Bebe");

            builder.HasOne(x => x.Parto)
                .WithMany(x => x.Bebes)
                .HasForeignKey(x => x.IdParto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Parto_Bebe");

            builder.ToTable("Bebe");
        }
    }
}
