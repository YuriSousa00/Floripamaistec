using M1S10_Projeto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M1S10_Projeto.Configurations
{
    public class Student_DisciplineConfig : IEntityTypeConfiguration<Student_Discipline>
    {
        public void Configure(EntityTypeBuilder<Student_Discipline> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.IdStudent)
                .HasColumnName("Id_Student");

            builder.Property(p => p.IdDiscipline)
                .HasColumnName("Id_Discipline");

            builder.ToTable("Student_Discipline");

        }
    }
}
