using M1S10_Projeto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M1S10_Projeto.Configurations
{
    public class DisciplineConfig : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Disciplines)
                .HasColumnName("Disciplines")
                .HasMaxLength(40);

            builder.Property(p => p.IdTeacher)
                .HasColumnName("Id_Teacher");



            builder.ToTable("Discipline");
            
        }

    }
}
