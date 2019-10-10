using Microsoft.AspNetCore.Mvc;
using transacao_cartao_api.Entities;

namespace transacao_cartao_api.Controllers
{
    /// <summary>
    /// Controlador de pagamento com cartão
    /// </summary>
    [Route("v1/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {

        /// <summary>
        /// Retorna os detalhes do pagamento após ele ser realizado
        /// </summary>
        /// <param name="pagamento"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Pagamento> PostPayment([FromBody]Pagamento pagamento)
        {
            return Ok(pagamento);
        }
    }
}