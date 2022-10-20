using Microsoft.AspNetCore.Mvc;
using WebApiRest.Application;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IvaController : ControllerBase
    {
        private ManagerMain managerMain;

        public IvaController()
        {
            managerMain = new ManagerMain();
        }

        /// <summary>
        /// Retorna el valor de IVA Tasa 1 de un pais determinado
        /// </summary>
        /// <param name="codeCountry">Codigo del pais</param>
        /// <param name="amount">Monto a aplicar el IVA</param>
        /// <returns></returns>
        [HttpGet("tax1/{codeCountry}/{amount}")]
        public IActionResult GetIVATax1(string codeCountry, double amount)
        {
            if(codeCountry == null)
                return BadRequest("Codigo de pais nulo");

            var response = managerMain.GetInfoIvaCoiuntry(codeCountry, 1, amount);

            return Ok(response);
        }

        /// <summary>
        /// Retorna el valor de IVA Tasa 2 de un pais determinado
        /// </summary>
        /// <param name="codeCountry">Codigo del pais</param>
        /// <param name="amount">Monto a aplicar el IVA</param>
        /// <returns></returns>
        [HttpGet("tax2/{codeCountry}/{amount}")]
        public IActionResult GetIVATax2(string codeCountry, double amount)
        {
            if (codeCountry == null)
                return BadRequest("Codigo de pais nulo");

            var response = managerMain.GetInfoIvaCoiuntry(codeCountry, 2, amount);

            return Ok(response);
        }
    }
}