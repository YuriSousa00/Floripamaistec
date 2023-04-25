using M1S10_Projeto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M1S10_Projeto.Configurations
{
    public class QuestionConfig : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(p => p.Enunciation)
                .HasColumnName("Enunciation")
                .HasMaxLength(40);

            builder.Property(p => p.Weight)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.IdQuiz)
                .HasColumnName("Id_Quiz");

            builder.ToTable("Question");
        }
    }
}
