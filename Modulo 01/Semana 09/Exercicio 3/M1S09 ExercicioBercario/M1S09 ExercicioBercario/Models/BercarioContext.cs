using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using M1S09_ExercicioBercario.Configurations;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Extensions.Options;


namespace M1S09_ExercicioBercario.Models
{
    public class BercarioContext : DbContext
    {
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }

        public BercarioContext(DbContextOptions<BercarioContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4HA8L2L\\SQLEXPRESS;User ID=sa;Password=123456;Database=Bercario;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.ApplyConfiguration(new BebeConfig());
            modelBuilder.ApplyConfiguration(new MaeConfig());
            modelBuilder.ApplyConfiguration(new MedicoConfig());
            modelBuilder.ApplyConfiguration(new PartoConfig());
        }
    }
    
}
