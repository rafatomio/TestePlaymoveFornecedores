using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Fornecedores.Model
{
    public class FornecedorContext : DbContext
    {
        public FornecedorContext(DbContextOptions<FornecedorContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<FornecedorModel> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
