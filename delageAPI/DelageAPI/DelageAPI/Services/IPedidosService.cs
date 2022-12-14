using delageAPI.DTO;

namespace DelageAPI.Services
{
    public interface IPedidosService
    {

        Task<List<PedidoDTO>> TodosPedidos();
        Task<List<PedidoDTO>> PedidosIfood();
        Task<List<PedidoDTO>> PedidosRobin();
    }
}
