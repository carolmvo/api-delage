using delageAPI.DTO;

namespace DelageAPI.Services.Interfaces
{
    public interface IRequestRobinFood
    {
        Task<List<PedidoDTO>> GetPedidosRobin();
    }
}
