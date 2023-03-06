using ApiFuncionarios.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFuncionarios.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        /// <summary>
        /// Serviço para cadastro de funcionário na API
        /// </summary>
        [HttpPost]
        public IActionResult Post(FuncionariosPostModel model)
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para edição de funcionário na API
        /// </summary>
        [HttpPut]
        public IActionResult Put(FuncionariosPutModel model)
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para exclusão de funcionário na API
        /// </summary>
        [HttpDelete("{idFuncionario}")]
        public IActionResult Delete(Guid? idFuncionario)
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para consultar todos os funcionários na API
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(List<FuncionariosGetModel>), 200)]
        public IActionResult GetAll()
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para consultar um funcionário na API
        /// </summary>
        [HttpGet("{idFuncionario}")]
        [ProducesResponseType(typeof(FuncionariosGetModel), 200)]
        public IActionResult GetById(Guid? idFuncionario)
        {
            return Ok();
        }
    }
}
