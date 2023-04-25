using M1S10_Projeto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace M1S10_Projeto.Configurations
{
    public class AnswerConfig : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder) 
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Answers)
                .HasColumnName("Answers")
                .HasMaxLength(180);

            builder.Property(p => p.Score)
                .HasColumnType("float");

            builder.Property(p => p.Observation)
                .HasColumnName("Observation")
                .HasMaxLength(180);

            builder.Property(p => p.IdQuestion)
                .HasColumnName("Id_Question");

            builder.Property(p => p.IdStudent)
                .HasColumnName("Id_Student");

           
            

            builder.ToTable("Answer");

        }

    }
}
