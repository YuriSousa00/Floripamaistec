using M1S09_ExercicioBercario.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace M1S09_ExercicioBercario.Configurations
{
    public class MaeConfig : IEntityTypeConfiguration<Mae>
    {
        public void Configure(EntityTypeBuilder<Mae> builder)
        {
            builder.ToTable("Mae")
               .HasKey(e => e.Id);


        }
    }
}
