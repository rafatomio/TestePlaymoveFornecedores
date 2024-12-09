using Fornecedores.Model;
using Microsoft.AspNetCore.Mvc;

namespace Fornecedor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<FornecedorModel>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}
