
namespace robinAPI.DTO
{
    public class PedidoDTO
    {
        public int IdPedido { get; set; }
        public double PrecoPedido { get; set; }
        public string NomeProduto { get; set; }
        public string NomeRestaurante { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime? DataPedido { get; set; }
        public string? Referencia { get; set; }


        public PedidoDTO(int idPedido, double precoPedido, string nomeProduto, string nomeRestaurante, string nomeUsuario, DateTime? dataPedido, string? referencia)
        {
            IdPedido = idPedido;
            NomeProduto = nomeProduto;
            NomeRestaurante = nomeRestaurante;
            NomeUsuario = nomeUsuario;
            DataPedido = dataPedido;
            PrecoPedido = precoPedido;
            Referencia = referencia;
        }
    }
}
