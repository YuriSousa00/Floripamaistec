using M1S09_ExercicioBercario.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace M1S09_ExercicioBercario.Configurations
{
    public class MedicoConfig : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medico")
               .HasKey(e => e.Id);

        }
    }
}
