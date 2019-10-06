using transacao_cartao_api.Util.Enum;

namespace transacao_cartao_api.Entities
{
    public class PedidoCabecalho
    {
        public int Id { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public string UsuarioNome { get; set; }
    }
}
