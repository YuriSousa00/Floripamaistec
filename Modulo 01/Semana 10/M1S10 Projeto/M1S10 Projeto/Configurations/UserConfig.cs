using M1S10_Projeto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M1S10_Projeto.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .HasMaxLength(50);

            builder.Property(p => p.Email)
                .HasColumnName("Email")
                .HasMaxLength(50);

            builder.Property(p => p.Password)
                .HasColumnName("Password")
                .HasMaxLength(50);

            builder.Property(p => p.CPF)
                .HasColumnName("CPF");
                

            builder.ToTable("User");


        }
    }
}
