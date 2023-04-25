using M1S10_Projeto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M1S10_Projeto.Configurations
{
    public class QuizConfig : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        { 
             builder.HasKey(e => e.Id);

            builder.Property(p => p.Title)
                .HasColumnName("Title")
                .HasMaxLength(30);

            builder.Property(e => e.IdDiscipline)
                .HasColumnName("Id_Discipline");


            builder.ToTable("Quiz");
        }
    }
}
