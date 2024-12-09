using Fornecedores.Model;
using Fornecedores.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fornecedor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {

        private readonly IFornecedorRepositorio repositorioFornecedor;

        public FornecedorController(IFornecedorRepositorio fornecedorRepositorio)
        {
            repositorioFornecedor = fornecedorRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<FornecedorModel>>> BuscarTodosUsuarios()
        {
            List<FornecedorModel> fornecedor = await repositorioFornecedor.BuscarTodosFornecedores();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<FornecedorModel>>> BuscarPorId(int id)
        {
            FornecedorModel fornecedor = await repositorioFornecedor.BuscarFornecedorPorId(id);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<FornecedorModel>> Cadastrar([FromBody] FornecedorModel fornecedorModel)
        {
            FornecedorModel fornecedor = await repositorioFornecedor.Adicionar(fornecedorModel);
            return Ok(fornecedor);
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult<FornecedorModel>> Atualizar([FromBody] FornecedorModel fornecedorModel, int id)
        {
            fornecedorModel.Id = id;
            FornecedorModel fornecedor = await repositorioFornecedor.Atualizar(fornecedorModel, id);
            return Ok(fornecedor);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FornecedorModel>> Apagar(int id)
        {
            bool apagado = await repositorioFornecedor.Apagar(id);
            return Ok(apagado);
        }

    }
}
