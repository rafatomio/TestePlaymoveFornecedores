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
    }
}
