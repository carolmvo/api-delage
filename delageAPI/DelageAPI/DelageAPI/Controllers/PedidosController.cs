using DelageAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DelageAPI.Controllers
{
    [Route("/")]
    [ApiController]
    public class PedidosController : ControllerBase
    {

        private readonly IPedidosService pedidoService;

        public PedidosController(IPedidosService pedidoService)
        {
            this.pedidoService = pedidoService;
        }

        [HttpGet("ifood")]
        public async Task<IActionResult> PedidosIfood()
        {
            var pedidos = await pedidoService.PedidosIfood();
            return Ok(pedidos);
        }

        [HttpGet("robin")]
        public async Task<IActionResult> PedidosRobin()
        {
            var pedidos = await pedidoService.PedidosRobin();
            return Ok(pedidos);
        }

        [HttpGet("pedidos")]
        public async Task<IActionResult> Pedidos()
        {
            var pedidos = await pedidoService.TodosPedidos();
            return Ok(pedidos);
        }
    }
}
