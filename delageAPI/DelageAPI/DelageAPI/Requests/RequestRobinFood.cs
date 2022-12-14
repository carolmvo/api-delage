using delageAPI.DTO;
using DelageAPI.Services.Interfaces;
using System.Text.Json;

namespace DelageAPI.Services
{
    public class RequestRobinFood : IRequestRobinFood
    {
        public async Task<List<PedidoDTO>> GetPedidosRobin()
        {
            List<PedidoDTO> pedidos = new List<PedidoDTO>();
            var response = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                var request = await client.GetAsync("https://devrobindelageest.azurewebsites.net/pedidos");

                if (request.IsSuccessStatusCode)
                {
                    response = await request.Content.ReadAsStringAsync();
                }

                pedidos = JsonSerializer.Deserialize<List<PedidoDTO>>(response);
            }

            return pedidos;
        }
    }
}
