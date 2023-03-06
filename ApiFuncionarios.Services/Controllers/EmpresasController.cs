using ApiFuncionarios.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFuncionarios.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        /// <summary>
        /// Serviço para cadastro de empresa na API
        /// </summary>
        [HttpPost]
        public IActionResult Post(EmpresasPostModel model)
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para edição de empresa na API
        /// </summary>
        [HttpPut]
        public IActionResult Put(EmpresasPutModel model)
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para exclusão de empresa na API
        /// </summary>
        [HttpDelete("{idEmpresa}")]
        public IActionResult Delete(Guid? idEmpresa)
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para consultar todas as empresas na API
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(List<EmpresasGetModel>), 200)]
        public IActionResult GetAll()
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para consultar uma empresa na API
        /// </summary>
        [HttpGet("{idEmpresa}")]
        [ProducesResponseType(typeof(EmpresasGetModel), 200)]
        public IActionResult GetById(Guid? idEmpresa)
        {
            return Ok();
        }
    }
}
