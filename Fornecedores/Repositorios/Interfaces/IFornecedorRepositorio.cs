using Fornecedores.Model;

namespace Fornecedores.Repositorios.Interfaces
{
    public interface IFornecedorRepositorio
    {
        Task<List<FornecedorModel>> BuscarTodosFornecedores()
        Task<FornecedorModel> BuscarFornecedorPorId(int id);
        Task<FornecedorModel> Adicionar(FornecedorModel fornecedor);

        Task<FornecedorModel> Atualizar(FornecedorModel fornecedor, int id);

        Task<bool> Apagar(int id);

    }
}
