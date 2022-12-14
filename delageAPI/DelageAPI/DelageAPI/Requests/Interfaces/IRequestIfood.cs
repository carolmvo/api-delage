using delageAPI.DTO;

namespace DelageAPI.Services.Interfaces
{
    public interface IRequestIfood
    {
        Task<List<PedidoDTO>> GetPedidosIfood();
    }
}
