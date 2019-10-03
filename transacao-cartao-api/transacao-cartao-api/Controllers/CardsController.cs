using System;
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
    public class CardsController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Card> PostCard([FromBody]Card p_Card)
        {
            //Verificar se há algum valor null para retornar código inválido
            Card v_Card = new Card
            {
                Id = 10,
                Brand = p_Card.Brand,
                CardHolderName = p_Card.CardHolderName,
                ExpirationMonth = p_Card.ExpirationMonth,
                ExpirationYear = p_Card.ExpirationYear,
                SecurityCode = p_Card.SecurityCode,
                CustomerId = p_Card.CustomerId,
            };

            return Ok(v_Card);
        }

        //[HttpPost("payments")]
        //public ActionResult<Card> PostPayment([FromBody]Payment p_Payment)
        //{
        //    //Verificar se há algum valor null para retornar código inválido
        //    Payment v_Payment = new Payment
        //    {
        //        Id = 10,
        //        Brand = p_Card.Brand,
        //        CardHolderName = p_Card.CardHolderName,
        //        ExpirationMonth = p_Card.ExpirationMonth,
        //        ExpirationYear = p_Card.ExpirationYear,
        //        SecurityCode = p_Card.SecurityCode,
        //        CustomerId = p_Card.CustomerId,
        //    };

        //    return Ok(v_Payment);
        //}
    }
}