using delageAPI.Models;

namespace delageAPI.DTO
{
    public class PedidoDTO
    {
        public int idPedido { get; set; }
        public double precoPedido { get; set; }
        public string nomeProduto { get; set; }
        public string nomeRestaurante { get; set; }
        public string nomeUsuario { get; set; }
        public DateTime? dataPedido { get; set; }
        public string? referencia { get; set; }


        public PedidoDTO(int idPedido, double precoPedido, string nomeProduto, string nomeRestaurante, string nomeUsuario, DateTime? dataPedido, string? referencia)
        {
            this.idPedido = idPedido;
            this.nomeProduto = nomeProduto;
            this.nomeRestaurante = nomeRestaurante;
            this.nomeUsuario = nomeUsuario;
            this.dataPedido = dataPedido;
            this.precoPedido = precoPedido;
            this.referencia = referencia;
        }
    }
}
