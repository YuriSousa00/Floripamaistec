using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using M1S09_ExercicioBercario.Configurations;


namespace M1S09_ExercicioBercario.Models
{
    public class BercarioContext : DbContext
    {
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.ApplyConfiguration(new BebeConfig());
            modelBuilder.ApplyConfiguration(new MaeConfig());
            modelBuilder.ApplyConfiguration(new MedicoConfig());
            modelBuilder.ApplyConfiguration(new PartoConfig());
        }

    }
}
