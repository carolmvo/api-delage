using robinAPI.DTO;
using robinAPI.Models;

namespace robinAPI.Services
{
    public interface IPedidoService
    {

        Task<List<PedidoDTO>> ListarPedidos();
        Task<List<PedidoDTO>> ListarPedidosPorRestaurante(int idRestaurante);
        Task<UsuarioModel> UsuarioPorId(int id);
        void AtualizarPedidos(int idUsuario);

    }
}