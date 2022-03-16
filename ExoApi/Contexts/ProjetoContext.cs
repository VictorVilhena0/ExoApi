using ExoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoApi.Contexts
{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext()
        {
        }

        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {

        }

        // vamos utilizar esse método para configurar o banco de dados
        protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-JTA7A8U; initial catalog = psbe; Integrated Security = true");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção

        public DbSet<Projeto> Projeto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
