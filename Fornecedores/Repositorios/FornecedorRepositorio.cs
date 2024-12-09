using Fornecedores.Data;
using Fornecedores.Model;
using Fornecedores.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fornecedores.Repositorios
{
    public class FornecedorRepositorio : IFornecedorRepositorio
    {
        private readonly SistemaFornecedorDbContext _dbContext;
        public FornecedorRepositorio(SistemaFornecedorDbContext sistemaFornecedorDbContext)
        {
            _dbContext = sistemaFornecedorDbContext;
        }

        public async Task<FornecedorModel> BuscarFornecedorPorId(int id)
        {
            return await _dbContext.Fornecedores.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<FornecedorModel>> BuscarTodosFornecedores()
        {
            return await _dbContext.Fornecedores.ToListAsync();
        }
        public async Task<FornecedorModel> Adicionar(FornecedorModel fornecedor)
        {
            _dbContext.Fornecedores.AddAsync(fornecedor);
            _dbContext.SaveChangesAsync();

            return  fornecedor;
        }
        public async Task<FornecedorModel> Atualizar(FornecedorModel fornecedor, int id)
        {
            FornecedorModel fornecedorPorId = await BuscarFornecedorPorId(id);

            if (fornecedorPorId == null)
            {
                throw new Exception($"O fornecedor para o ID: {id} não foi encontrado no banco de dados.");
            }
            fornecedorPorId.Nome = fornecedor.Nome;
            fornecedorPorId.Email = fornecedor.Email;

            _dbContext.Fornecedores.Update(fornecedorPorId);
            _dbContext.SaveChangesAsync();
            
            return fornecedorPorId;
        }
        public async Task<bool> Apagar(int id)
        {
            FornecedorModel fornecedorPorId = await BuscarFornecedorPorId(id);

            if (fornecedorPorId == null)
            {
                throw new Exception($"O fornecedor para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Fornecedores.Remove(fornecedorPorId);
            _dbContext.SaveChangesAsync();
            
            return true;
        }
    }
}
