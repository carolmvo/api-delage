using robinAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace robinAPI.Data
{
    public class RobinContext : DbContext
    {
        public RobinContext(DbContextOptions<RobinContext> options) : base(options) { }

        public virtual DbSet<PedidoModel> Pedidos { get; set; }
        public virtual DbSet<RestauranteModel> Restaurantes { get; set; }
        public virtual DbSet<ProdutoModel> Produtos { get; set; }
        public virtual DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
