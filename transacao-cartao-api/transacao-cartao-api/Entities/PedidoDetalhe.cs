using System.Collections.Generic;

namespace transacao_cartao_api.Entities
{
    public class PedidoDetalhes
    {
        public int Id { get; set; }
        public int PedidoCabecalhoId { get; set; }
        public int LivroId { get; set; }
    }
}