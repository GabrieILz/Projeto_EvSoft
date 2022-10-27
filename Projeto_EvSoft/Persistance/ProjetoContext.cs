using Microsoft.EntityFrameworkCore;
using Projeto_EvSoft.Models;

namespace Projeto_EvSoft.Persistance
{
    public class ProjetoContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Contato> Contatos { get; set; }

        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {

        }
    }
}
