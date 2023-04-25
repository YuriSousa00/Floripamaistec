using M1S10_Projeto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M1S10_Projeto.Configurations
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {

            builder.Property(p => p.Departament)
                .HasColumnName("Departament")
                .HasMaxLength(50);

            builder.Property(p => p.IdUser)
                .HasColumnName("Id_User");

            

            builder.ToTable("Teacher");
        }
    }
    
    
}
