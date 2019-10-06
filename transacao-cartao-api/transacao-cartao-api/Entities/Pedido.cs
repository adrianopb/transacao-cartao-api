using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transacao_cartao_api.Entities
{
    public class Pedido
    {
        public PedidoCabecalho PedidoCabecalho { get; set; }
        public IEnumerable<PedidoDetalhes> PedidoDetalhes { get; set; }
    }
}
