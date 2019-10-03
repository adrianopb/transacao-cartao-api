using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transacao_cartao_api.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }
        public CarrinhoLivros CarrinhoLivros { get; set; }
        public Card Card { get; set; }
    }
}
