using Fornecedores.Model;
using Microsoft.EntityFrameworkCore;

namespace Fornecedores.Data
{
    public class SistemaFornecedorDbContext : DbContext
    {

        public SistemaFornecedorDbContext(DbContextOptions<SistemaFornecedorDbContext> options) : base(options) 
        {
        }

        public DbSet<FornecedorModel> Fornecedores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
