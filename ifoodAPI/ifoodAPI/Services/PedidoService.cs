using ifoodAPI.Data;
using ifoodAPI.Models;
using ifoodAPI.DTO;
using Microsoft.EntityFrameworkCore;

namespace ifoodAPI.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IfoodContext context;

        public PedidoService(IfoodContext context)
        {
            this.context = context;
        }


        public async Task<List<PedidoDTO>> ListarPedidos()
        {
            List<PedidoModel> pedidos = await context.Pedidos.ToListAsync();

            List<PedidoDTO> pedidosDTO = new();
            foreach (var pedido in pedidos)
            {
                var restaurante = await context.Restaurantes.FirstOrDefaultAsync(x => x.IdRestaurante == pedido.IdRestaurante);
                var produto = await context.Produtos.FirstOrDefaultAsync(x => x.IdProduto == pedido.IdProduto);
                var usuario = await context.Usuarios.FirstOrDefaultAsync(x => x.IdUsuario == pedido.IdUsuario);

                if (!(restaurante == null || produto == null || usuario == null))
                {
                    PedidoDTO dto = new(pedido.IdPedido, produto.Preco, produto.NomeProduto, restaurante.Nome, usuario.Nome, pedido.DataPedido, pedido.Referencia);
                    pedidosDTO.Add(dto);
                }
            }
            return pedidosDTO;
        }


        public async Task<List<PedidoDTO>> ListarPedidosPorRestaurante(int idRestaurante)
        {
            List<PedidoModel> pedidos = await context.Pedidos.ToListAsync();
            List<PedidoDTO> pedidosDTO = new();

            if (!pedidos.Any()) return pedidosDTO;

            foreach (var pedido in pedidos)
            {
                if (pedido.IdRestaurante == idRestaurante)
                {

                    var restaurante = await context.Restaurantes.FirstOrDefaultAsync(x => x.IdRestaurante == pedido.IdRestaurante);
                    var produto = await context.Produtos.FirstOrDefaultAsync(x => x.IdProduto == pedido.IdProduto);
                    var usuario = await context.Usuarios.FirstOrDefaultAsync(x => x.IdUsuario == pedido.IdUsuario);

                    if (!(restaurante == null || produto == null || usuario == null))
                    {
                        PedidoDTO dto = new(pedido.IdPedido, produto.Preco, produto.NomeProduto, restaurante.Nome, usuario.Nome, pedido.DataPedido, pedido.Referencia);
                        pedidosDTO.Add(dto);
                    }
                }
            }

            return pedidosDTO;

        }

        public async Task<UsuarioModel> UsuarioPorId(int id)
        {
            return await context.Usuarios.FindAsync(id);
        }

        public async void AtualizarPedidos(int idUsuario)
        {

            var pedidosList = context.Pedidos.ToList();

            foreach (PedidoModel pedido in pedidosList)
            {
                if (pedido.IdUsuario == idUsuario)
                {
                    var usuario = await UsuarioPorId(idUsuario);

                    var produto = context.Produtos.Find(pedido.IdProduto);
                    var restaurante = context.Restaurantes.Find(pedido.IdRestaurante);

                    if (produto != null && restaurante != null)
                    {
                        pedido.Produto = produto;
                        pedido.Restaurante = restaurante;
                    }
                    usuario.Pedidos.Add(pedido);

                }
            }
        }
    }
}
