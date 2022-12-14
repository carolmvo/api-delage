using delageAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DelageAPI.Data
{
    public class DelageContext : DbContext
    {
        public DelageContext(DbContextOptions<DelageContext> options) : base(options) { }

        public virtual DbSet<PedidoModel> Pedidos { get; set; }
        public virtual DbSet<RestauranteModel> Restaurantes { get; set; }
        public virtual DbSet<ProdutoModel> Produtos{ get; set; }
        public virtual DbSet<UsuarioModel> Usuarios{ get; set; }
    }
}
