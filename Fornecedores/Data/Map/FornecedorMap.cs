using Fornecedores.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fornecedores.Data.Map
{
    public class FornecedorMap : IEntityTypeConfiguration<FornecedorModel>
    {
        public void Configure(EntityTypeBuilder<FornecedorModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
        }
    }
}
