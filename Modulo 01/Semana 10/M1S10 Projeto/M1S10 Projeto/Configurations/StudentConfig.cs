using M1S10_Projeto.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace M1S10_Projeto.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.Property(p => p.Period)
                .HasColumnName("Periodo")
                .HasColumnType("Int");

            builder.Property(p => p.RA)
                .HasColumnName("RA");

            builder.Property(p => p.IdUser)
            .HasColumnName("Id_User");

            

            builder.HasData(new[]
            {
                new Student() {Id = 1, Name = "Olivia", Email = "user@hotmail.com", CPF = "1234567891", Password = "1admin" },
                new Student() {Id = 2, Name = "Miguel", Email = "user2@hotmail.com", CPF = "1223123822", Password = "123admin" }
            });

            builder.ToTable("Student");
        }
    }   
}