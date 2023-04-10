using M1S09_Criar_modelos_e_contexto.Models;
using Microsoft.EntityFrameworkCore;

namespace M1S09_Criar_modelos_e_contexto
{
    public class BercarioContexto : DbContext
    {
        public DbSet<Bebe>Bebes { get; set; }   
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }

    }
}
