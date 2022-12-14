using ifoodAPI.Models;
using ifoodAPI.Services;
using ifoodAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Ifood.Controllers
{
    [ApiController]
    public class PedidosController : Controller
    {

        private readonly IPedidoService pedidoService;

        public PedidosController(IPedidoService pedidoService)
        {
            this.pedidoService = pedidoService;
        }

        [HttpGet("pedidos")]
        public async Task<IActionResult> Pedidos()
        {
            var pedidos = await pedidoService.ListarPedidos();
            return Ok(pedidos);
        }

        [HttpGet("pedidos/{idUsuario}")]
        public async Task<IActionResult> Pedidos([FromRoute] int idUsuario)
        {

            var usuario = await pedidoService.UsuarioPorId(idUsuario);

            if (usuario != null)
            {
                pedidoService.AtualizarPedidos(idUsuario);
                List<PedidoModel> pedidos = usuario.Pedidos;
                return Ok(pedidos);
            }

            return NotFound(new { message = "usuário não encontrado!", codeStatus = 404});
        }

        [HttpGet("pedidos/restaurante/{idRestaurante}")]
        public async Task<IActionResult> Pedidos([FromRoute] int idRestaurante, string? empty)
        {
            try
            {
                List<PedidoDTO> pedidos = await pedidoService.ListarPedidosPorRestaurante(idRestaurante);
                return Ok(pedidos);
            } catch(Exception ex)
            {
                return BadRequest(new {message = ex.Message, codeStatus = 400});
            }


        }

    }
}
