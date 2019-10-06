using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using transacao_cartao_api.Entities;

namespace transacao_cartao_api.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        //Recebe um POST da API de Pagamento
        [HttpPost]
        public ActionResult<Payment> PostPayment([FromBody]Payment payment)
        {
            var a = 1;
        
            Payment v_Payment = new Payment()
            {
                
            };

            return v_Payment;
        }
    }
}