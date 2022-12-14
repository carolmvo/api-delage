using ifoodAPI.DTO;
using ifoodAPI.Models;

namespace ifoodAPI.Services
{
    public interface IPedidoService
    {

        Task<List<PedidoDTO>> ListarPedidos();
        Task<List<PedidoDTO>> ListarPedidosPorRestaurante(int idRestaurante);
        Task<UsuarioModel> UsuarioPorId(int id);
        void AtualizarPedidos(int idUsuario);

    }
}