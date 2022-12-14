using delageAPI.DTO;
using delageAPI.Models;
using DelageAPI.Data;
using DelageAPI.Services.Interfaces;

namespace DelageAPI.Services
{
    public class PedidosService : IPedidosService
    {

        private readonly IRequestIfood requestIfood;
        private readonly IRequestRobinFood requestRobin;

        public PedidosService(IRequestIfood requestIfood, IRequestRobinFood requestRobin)
        {
            this.requestIfood = requestIfood;
            this.requestRobin = requestRobin;
        }

        public async Task<List<PedidoDTO>> PedidosIfood()
        {
            List<PedidoDTO> pedidos = await requestIfood.GetPedidosIfood();
            return pedidos;

        }

        public async Task<List<PedidoDTO>> PedidosRobin()
        {
            List<PedidoDTO> pedidos = await requestRobin.GetPedidosRobin();
            return pedidos;
        }

        public async Task<List<PedidoDTO>> TodosPedidos()
        {
            List<PedidoDTO> robin = await requestRobin.GetPedidosRobin();
            List<PedidoDTO> ifood = await requestIfood.GetPedidosIfood();

            List<PedidoDTO> pedidos = robin.Concat(ifood).ToList();
            return pedidos;
            
        }
    }
}
