using System.IO;
using M1S10_Projeto.Configurations;
using M1S10_Projeto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace M1S10_Projeto.Models
{
    public class ProjetoContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Discipline> StudentDisciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }


        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.ApplyConfiguration(new AnswerConfig());
            modelBuilder.ApplyConfiguration(new DisciplineConfig());
            modelBuilder.ApplyConfiguration(new QuestionConfig());
            modelBuilder.ApplyConfiguration(new QuizConfig());
            modelBuilder.ApplyConfiguration(new Student_DisciplineConfig());
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new TeacherConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
