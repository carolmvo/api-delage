using ifoodAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ifoodAPI.Data
{
    public class IfoodContext : DbContext
    {
        public IfoodContext(DbContextOptions<IfoodContext> options) : base(options) { }

        public virtual DbSet<PedidoModel> Pedidos { get; set; }
        public virtual DbSet<RestauranteModel> Restaurantes { get; set; }
        public virtual DbSet<ProdutoModel> Produtos { get; set; }
        public virtual DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
